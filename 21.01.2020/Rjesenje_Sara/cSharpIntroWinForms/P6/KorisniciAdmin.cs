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
        }

        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? konekcijaNaBazu.Korisnici.ToList();

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = rezultati;

            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtPretraga.Text.ToLower().Trim();
                var pretraga = konekcijaNaBazu.Korisnici.Where(x => x.Ime.ToLower().Trim().Contains(filter)
                || x.Prezime.ToLower().Trim().Contains(filter)).ToList();

                //var proba = pretraga.Where(x => x.Uspjeh.Average(x => x.Ocjena));
                //var prosjek = pretraga.Select(x => new { prosjek = x.Uspjeh.Average(y => y.Ocjena) }).Average(x => x.prosjek);
                double suma = 0;
                double sumaPredmeta = 0;
                for (int i = 0; i < pretraga.Count; i++)
                {
                    double sumaOcjena = pretraga[i].Uspjeh.Sum(x => x.Ocjena);
                    //sumaOcjena /= pretraga[i].Uspjeh.Count;
                    suma += sumaOcjena;
                    sumaPredmeta += pretraga[i].Uspjeh.Count;
                }
                lblProsjek.Text = $"Prosjek ocjena je: {suma / sumaPredmeta}";

                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = pretraga;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                KorisniciPolozeniPredmeti korisniciPolozeniPredmeti = new KorisniciPolozeniPredmeti
                    (dgvKorisnici.CurrentRow.DataBoundItem as Korisnik);
                korisniciPolozeniPredmeti.Show();
            }
        }
    }
}
