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
        }



        private void LoadData(List<Korisnik> korisnici = null)
        {
            try
            {
                List<Korisnik> rezultati = korisnici ?? _baza.Korisnici.ToList();

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
            var filter = txtPretraga.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                return;
            }
            var pretraga = _baza.Korisnici.Where(x => x.Ime.Trim().ToLower().Contains(filter)
              || x.Prezime.Trim().ToLower().Contains(filter)).ToList();
            LoadData(pretraga);

            double prosjek = 0, suma = 0;
            int brojac = 0;
            for (int i = 0; i < pretraga.Count; i++)
            {
                for (int j = 0; j < pretraga[i].Uspjeh.Count; j++)
                {
                    suma += pretraga[i].Uspjeh[j].Ocjena;
                    brojac = pretraga[i].Uspjeh.Count;
                }
            }
            prosjek = suma / brojac;
            lblProsjek.Text = $"Prosječna ocjena: {prosjek}";
        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var x = dgvKorisnici.CurrentRow.DataBoundItem as Korisnik;
                KorisniciPolozeniPredmeti forma = new KorisniciPolozeniPredmeti(x);
                forma.Show();
            }
        }
    }
}
