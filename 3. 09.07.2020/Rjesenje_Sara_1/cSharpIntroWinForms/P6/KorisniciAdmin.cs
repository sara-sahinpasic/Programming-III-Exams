using cSharpIntroWinForms.IB140261;
using cSharpIntroWinForms.IB140261.ReportiIB140261;
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

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;

        public KorisniciAdmin()
        {
            InitializeComponent();
            dgvKorisnici.AutoGenerateColumns = false;
        }

        private void KorisniciAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            txtPretraga.Select();
            LoadData_Spolovi();
        }

        private void LoadData_Spolovi(List<Spolovi> spolovi = null)
        {
            try
            {
                cmbSpol.ValueMember = "Id";
                cmbSpol.DisplayMember = "Naziv";
                cmbSpol.DataSource = spolovi ?? konekcijaNaBazu.Spolovi.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }
        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnici ?? konekcijaNaBazu.Korisnici.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();

            KorisniciSlikeIB140261 slika = dgvKorisnici.CurrentRow.DataBoundItem as KorisniciSlikeIB140261;
            if (e.ColumnIndex == 5)
            {
                frmKorisnikSlikePregledIB140261 frmKorisnikSlikePregledIB140261 = new frmKorisnikSlikePregledIB140261(slika);
                frmKorisnikSlikePregledIB140261.ShowDialog();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.Trim().ToLower();
            //var spol = cmbSpol.SelectedItem as Spolovi;
            //var admin = cbAdministrator.Checked;

            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                return;
            }

            var pretraga = konekcijaNaBazu.Korisnici.Where(
                x => x.Ime.Trim().ToLower().Contains(filter)
                || x.Prezime.Trim().ToLower().Contains(filter)
                /*&& x.Spol.Naziv.Contains(spol.Naziv) 
                && x.Admin == admin*/).ToList();

            LoadData(pretraga);
        }

        private void cmbSpol_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filter = cmbSpol.SelectedItem as Spolovi;
            var pretraga = konekcijaNaBazu.Korisnici.Where(x => x.Spol.Id == filter.Id).ToList();

            LoadData(pretraga);
        }

        private void cbAdministrator_CheckedChanged(object sender, EventArgs e)
        {
            var filter = cbAdministrator.Checked;
            var pretraga = konekcijaNaBazu.Korisnici.Where(x => x.Admin == filter).ToList();
            LoadData(pretraga);
        }

        private void btnPrintajPolozene_Click(object sender, EventArgs e)
        {
            var izvjestajKorisnik = dgvKorisnici.DataSource as List<Korisnik>;
            // //if (izvjestajKorisnik?.Count > 0)
            //// {
            //     frmIzvjestajIB140261 frmIzvjestajIB140261 = new frmIzvjestajIB140261(izvjestajKorisnik);
            //     frmIzvjestajIB140261.ShowDialog();
            //// }
            frmProba frmProba = new frmProba(izvjestajKorisnik);
            frmProba.Show();
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            var broj = int.Parse(txtUnosBroja.Text);
            double suma = 0;
            await Task.Run(() =>
            {
                suma = IzracunajSumu(broj);
            });
            MessageBox.Show($"Suma svih brojeva do broja {broj} je: {suma}");
        }

        private double IzracunajSumu(int broj)
        {
            double suma = 0;
            for (int i = 0; i < broj; i++)
            {
                suma += i;
            }
            return suma;
        }
    }
}
