using cSharpIntroWinForms.IB140261;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik _korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        public List<int> ocjena = new List<int>()
            {
                6,
                7,
                8,
                9,
                10
            };

        public KorisniciPolozeniPredmeti() //podrazumijevanom korisniku ne moram nista proslijediti, a u ovom primjeru ja moram nesto proslijediti kao sto sam u metodi ispod
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
            UcitajPodatke(); // IMPLEMENTIRATI učitavanje položenih predmeta
        }

        private void UcitajPodatke()
        {
            dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
        }


        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
            UcitajOcjene();
        }

        private void UcitajOcjene()
        {
            cmbOcjene.DataSource = ocjena;
        }

        private void UcitajPredmete()
        {
            if (cbUcitajNepolozene.Checked == true) //ako štrihirano učitaj sve predmete
            {
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";

                var polozeniPredmeti = _korisnik.Uspjeh.Select(y => y.Predmet.Id).ToList();

                cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.
                    Where(x => !polozeniPredmeti.Contains(x.Id)).ToList();
            }
            else
            {
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.DataSource = _korisnik.Uspjeh.Select(x => x.Predmet).ToList();
            }
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
            var odabranaOcjena = int.Parse(cmbOcjene.SelectedItem.ToString());
            var odabraniDatum = dtpDatumPolaganja.Value.ToString("dd.MM.yyyy");

            KorisniciPredmeti noviUnos = new KorisniciPredmeti();

            noviUnos.Predmet = odabraniPredmet;
            noviUnos.Ocjena = odabranaOcjena;
            noviUnos.Korisnik = _korisnik;
            noviUnos.Datum = odabraniDatum;

            konekcijaNaBazu.KorisniciPredmeti.Add(noviUnos);
            konekcijaNaBazu.SaveChanges();

            UcitajPodatke();
            UcitajPredmete();
            MessageBox.Show("Položeni predmet je dodan.");
        }

        private async void btnASYNC_Click(object sender, EventArgs e)
        {
            var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
            KorisniciPredmeti korisniciPredmeti = new KorisniciPredmeti();

            await Task.Run(() =>
            {
                for (int i = 0; i < 500; i++)
                {
                    korisniciPredmeti.Predmet = odabraniPredmet;
                    korisniciPredmeti.Ocjena = 5;
                    korisniciPredmeti.Datum = DateTime.Now.ToString();

                    korisniciPredmeti.Korisnik = _korisnik;

                    konekcijaNaBazu.KorisniciPredmeti.Add(korisniciPredmeti);
                    konekcijaNaBazu.SaveChanges();
                }
            });
            UcitajPodatke();
            MessageBox.Show("Uspješno je dodano 500 predmeta");
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            Izvjestaj izvjestaj = new Izvjestaj(_korisnik);
            izvjestaj.Show();
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            UcitajPredmete();
        }
    }
}
