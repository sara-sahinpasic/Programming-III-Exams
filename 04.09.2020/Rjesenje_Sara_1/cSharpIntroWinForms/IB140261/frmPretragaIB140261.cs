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

namespace cSharpIntroWinForms.IB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPolozeniPredmet.AutoGenerateColumns = false;
        }


        private void txtnazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //pretraga predemta po nazivu
                var unosKorisnika = txtnazivPredmeta.Text.ToLower().Trim();
                var pretragaPredmeta = baza.KorisniciPredmeti.
                    Where(x => x.Predmet.Naziv.ToLower().Trim().Contains(unosKorisnika)).ToList();

                //prosjek ocjena
                var prosjekOcjena = pretragaPredmeta.Average(x => x.Ocjena);
                var dvijeDecimale = Math.Round(prosjekOcjena, 2);
                if (pretragaPredmeta != null)
                {
                    dgvPolozeniPredmet.DataSource = null;
                    dgvPolozeniPredmet.DataSource = pretragaPredmeta;

                    if (pretragaPredmeta.Count == 0) //pretraga ne rezultira podacima
                        lblProsjekOcjena.Text = "0";
                    else
                    {
                        lblProsjekOcjena.Text = dvijeDecimale.ToString(); //prosjecna ocjena
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ ex.InnerException?.Message}");
            }

        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            dgvPolozeniPredmet.DataSource = null;
            dgvPolozeniPredmet.DataSource = baza.KorisniciPredmeti.ToList();
        }

        private void dgvPolozeniPredmet_CellContentClick(object sender, DataGridViewCellEventArgs e) //Threading
        {
            if (e.ColumnIndex == 4)
            {
                KorisniciPredmeti korisniciPredmeti = dgvPolozeniPredmet.CurrentRow.DataBoundItem as KorisniciPredmeti;

                //this.Hide();
                frmPorukeIB140261 frmPorukeIB140261 = new frmPorukeIB140261
                    (korisniciPredmeti.Korisnik);
                frmPorukeIB140261.Show();
            }
        }

        private int IzracunajSumu(int n)
        {
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += i;
            }
            return suma;
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {

            int n = int.Parse(txtThread.Text);
            int suma = 0;

            await Task.Run(() =>
            {
                suma = IzracunajSumu(n);
            });

            lblThreading.Text = suma.ToString();
        }
    }
}
