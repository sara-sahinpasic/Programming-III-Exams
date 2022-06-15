using cSharpIntroWinForms.IB140261;
using cSharpIntroWinForms.IB140261.Reporti;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik _korisnik;
        KonekcijaNaBazu _baza = DLWMS.DB;

        List<int> ocjene = new List<int>()
        {
            6,7,8,9,20
        };

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            //  _korisnik = _baza.Korisnici.FirstOrDefault();

        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }
        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            //    MessageBox.Show($"Broj Korisnika: {_baza.Korisnici.Count()}");
            LoadData();
            LoadPredmete();
            LoadGodineStudija();
        }

        private void LoadGodineStudija()
        {
            try
            {
                cmbGodineStudija.ValueMember = "Id";
                cmbGodineStudija.DisplayMember = "Naziv";
                cmbGodineStudija.DataSource = _baza.GodineStudija.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void LoadPredmete()
        {
            try
            {
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.DataSource = _baza.Predmeti.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }
        private void LoadData(List<KorisniciPredmeti> korisniciPredmeti = null)
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = korisniciPredmeti ?? _baza.KorisniciPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var x = dgvPolozeniPredmeti.DataSource as List<KorisniciPredmeti>;
            if (x?.Count > 0)
            {
                frmIzvjestajIB140261 frmIzvjestajIB140261 = new frmIzvjestajIB140261(x);
                frmIzvjestajIB140261.ShowDialog();
            }
        }
        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            try
            {
                //if (ValidirajUnos())
               // {
                    var predmet = cmbPredmeti.SelectedItem as Predmeti;
                    var ocjena = txtOcjene.Text;
                    var godinaStudija = cmbGodineStudija.SelectedItem as GodineStudija;
                    var datum = dtpDatumPolaganja.Value.ToString();

                    //Spolovi spolovi = new Spolovi();
                    //spolovi.Id = 2;
                    //Korisnik novi = new Korisnik()
                    //{
                    //    Id = 4,
                    //    Ime = "Sara",
                    //    Prezime = "Sahinpasic",
                    //    KorisnickoIme="ss",
                    //    Lozinka = "55555",
                    //    Admin=true,
                    //    Spol=spolovi
                    //};
                    //_baza.Korisnici.Add(novi);
                    //_baza.SaveChanges();

                    KorisniciPredmeti noviZapis = new KorisniciPredmeti();
                    Random random = new Random();
                   
                    noviZapis.Korisnik = _korisnik;
                    noviZapis.Predmet = predmet;
                    noviZapis.Ocjena = int.Parse(ocjena);
                    noviZapis.GodineStudija = godinaStudija;
                    noviZapis.Datum = datum;
                   // //var godina = _baza.KorisniciPredmeti.Select(x => x.GodineStudija.Naziv);
                   // var broj = _baza.KorisniciPredmeti.Select(x => x.GodineStudija).Count();
                   //// var postojecaGodinaStuijaKorisnika = _baza.KorisniciPredmeti.Where(x => x.GodineStudija == godinaStudija).ToList().Count();
                   // var postojeciPredmetKorisnika = _baza.KorisniciPredmeti.Where(x => x.Predmet.Id == predmet.Id).ToList().Count();
                   // if (/*postojecaGodinaStuijaKorisnika <= 0 &&*/ postojeciPredmetKorisnika <= 0)
                   // {
                        _baza.KorisniciPredmeti.Add(noviZapis);
                        _baza.SaveChanges();

                        LoadData();
                    //    MessageBox.Show("Predmet je dodan.");
                    //}
                    //else
                    //    MessageBox.Show("Isti zapis za studenta već postoji!");
               // }
                
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(cmbPredmeti, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(txtOcjene, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(cmbGodineStudija, err, Validator.porObaveznaVrijednost) &&
                Validator.ObaveznoPolje(dtpDatumPolaganja, err, Validator.porObaveznaVrijednost);
        }

    }
}
