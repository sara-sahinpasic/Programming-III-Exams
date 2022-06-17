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
        KonekcijaNaBazu _baza = DLWMS.DB;
        List<int> Ocjene = new List<int>()
        {
            6,7,8,9,10
        };

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
        }

        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCMB();
            cmbOcjene.DataSource = Ocjene;
        }

        private void LoadCMB()
        {
            var predmeti = _baza.Predmeti.ToList();

            if (cbUcitajNepolozene.Checked == false) //nije označen (uklonjena oznaka)
            {
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.DataSource = _baza.Predmeti.ToList();
            }
            else
            {
                var PretragaPolozeniPredmetiKorisnika =
                    _korisnik.Uspjeh.Select(x => x.Predmet.Id).ToList(); //selektuj (odaberi) predmete
                                                                         //koje KORISNIK ima položene

                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.DataSource = _baza.Predmeti.Where (x => 
                !PretragaPolozeniPredmetiKorisnika.Contains(x.Id)).ToList(); //dataSource neka budu svi
                                                                             //predmeti.Id koji se ne sadrze
                                                                             //unutar liste KORISNIK-ovih
                                                                             //položenih predmeta
            }
        }
        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            LoadCMB();
        }

        private void LoadData(List<KorisniciPredmeti> korisniciPredmeti = null)
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = korisniciPredmeti ?? _baza.KorisniciPredmeti
                    .Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            //var x = dgvPolozeniPredmeti.DataSource as List<Korisnik>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(_korisnik);
            forma.Show();
        }

        private async void btnASYNC_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmeti;
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    KorisniciPredmeti noviZapis = new KorisniciPredmeti()
                    {
                        Korisnik = _korisnik,
                        Predmet = predmet,
                        Ocjena = 6,
                        Datum = DateTime.Now.ToString()
                    };
                    _baza.KorisniciPredmeti.Add(noviZapis);
                }
                _baza.SaveChanges();
            });
            MessageBox.Show("Uspješno je dodano 500 predmeta.");
            LoadData();
        }
    }
}
