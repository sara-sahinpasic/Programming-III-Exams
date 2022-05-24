using cSharpIntroWinForms.IB140261;
using cSharpIntroWinForms.IB140261.Report;
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
        List<int> ocjene = new List<int>()
        {
                6,7,8,9,10
        };

        Korisnik _korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciPolozeniPredmeti(Korisnik korisnik)
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            _korisnik = korisnik;
        }

        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            LoadDataDGV();
            LoadDataCMB();
            LoadDataOcjene();
        }

        private void LoadDataOcjene()
        {
            cmbOcjene.DataSource = ocjene;
        }

        private void LoadDataCMB()
        {
            try
            {
                if (cbUcitajNepolozene.Checked == true)
                {
                    cmbPredmeti.ValueMember = "Id";
                    cmbPredmeti.DisplayMember = "Naziv";

                    var polozeniPredmetKorisnika = _korisnik.Uspjeh.Select(x => x.Predmet.Id).ToList();

                    cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.Where
                        (x => !polozeniPredmetKorisnika.Contains(x.Id)).ToList();
                }
                else
                {
                    cmbPredmeti.ValueMember = "Id";
                    cmbPredmeti.DisplayMember = "Naziv";
                    cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
                }
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void cbUcitajNepolozene_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataCMB();
        }

        private void LoadDataDGV(List<KorisniciPredmeti> korisniciPredmeti = null)
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = konekcijaNaBazu.KorisniciPredmeti.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine }{ex.InnerException?.Message }");
            }
        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            try
            {
                var ocjena = int.Parse(cmbOcjene.SelectedItem.ToString());
                var predmet = cmbPredmeti.SelectedItem as Predmeti;
                var datum = dtpDatumPolaganja.Value.ToString("dd.MM.yyyy");
                KorisniciPredmeti noviZapis = new KorisniciPredmeti();

                noviZapis.Predmet = predmet;
                noviZapis.Ocjena = ocjena;
                noviZapis.Datum = datum;
                noviZapis.Korisnik = _korisnik;

                konekcijaNaBazu.KorisniciPredmeti.Add(noviZapis);
                konekcijaNaBazu.SaveChanges();

                LoadDataDGV();
                MessageBox.Show("Predmet je dodan.");
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }
        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            frmIzvjestajIB140261_1 frmIzvjestajIB140261_1 = new frmIzvjestajIB140261_1(_korisnik);
            frmIzvjestajIB140261_1.ShowDialog();
        }

        private void btnASYNC_Click(object sender, EventArgs e)
        {
            DodajAsinhrono();
        }

        private async void DodajAsinhrono()
        {
            try
            {
                var OdabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;

                await Task.Run(() =>
                {
                    for (int i = 0; i < 3; i++) //500
                    {
                        KorisniciPredmeti noviPolozeni = new KorisniciPredmeti()
                        {
                            Predmet = OdabraniPredmet,
                            Ocjena = 6,
                            Datum = DateTime.Now.ToString()
                        };

                        _korisnik.Uspjeh.Add(noviPolozeni);
                        konekcijaNaBazu.SaveChanges();
                    }
                    //MessageBox.Show("Uspješno je dodano 500 predmeta");
                });
                LoadDataDGV();
                MessageBox.Show("Uspješno je dodano 500 predmeta");
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }
    }
}
