using cSharpIntroWinForms.IB140261;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms
{
    public partial class KorisniciAdmin : Form
    {
        KonekcijaNaBazu _baza = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadSpolCMB();
            txtPretraga.Select();
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? _baza.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }
        private void LoadSpolCMB()
        {
            cmbSpol.ValueMember = "Id";
            cmbSpol.DisplayMember = "Naziv";
            cmbSpol.DataSource = _baza.Spolovi.ToList();
           // cmbSpol.SelectedIndexChanged += cmbSpol_SelectedIndexChanged;
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //LoadData();
            if (e.ColumnIndex == 5)
            {
                var x = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                KorisnikSlikePregledIB140261 forma = new KorisnikSlikePregledIB140261(x);
                forma.Show();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            List<Korisnik> pretragaKorisnik = _baza.Korisnici.ToList(); /*new List<Korisnik>();*/

            var filterImePrezime = txtPretraga.Text.ToLower().Trim();
            var filterSpol = cmbSpol.SelectedItem as Spolovi;
            var filterAdmin = cbAdministrator.Checked;

            if (!string.IsNullOrEmpty(filterImePrezime))
            {
                pretragaKorisnik = pretragaKorisnik.Where(x => x.Ime.ToLower().Trim().Contains(filterImePrezime) ||
                x.Prezime.ToLower().Trim().Contains(filterImePrezime)).ToList();
            }
            if (filterSpol.Id != 3)
            {
                pretragaKorisnik = pretragaKorisnik.Where(x => x.Spol.Id == filterSpol.Id).ToList();
            }

            pretragaKorisnik = pretragaKorisnik.Where(x => x.Admin == filterAdmin).ToList();

            LoadData(pretragaKorisnik);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvKorisnici.DataSource as List<Korisnik>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
            forma.Show();
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            double suma = 0;
            var unos = int.Parse(txtSuma.Text);
            await Task.Run(() =>
            {
                suma = Sumiraj(unos);
            });
            lblSuma.Text = $"Rezultat sumiranja je: {suma}";
        }

        private double Sumiraj(int unos)
        {
            double suma = 0;
            for (int i = 0; i < unos; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}
