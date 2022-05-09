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
            dgvPretragaPredmeta.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            try
            {
                UcitajPredmete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void UcitajPredmete(List<KorisniciPredmeti> lista = null)
        {
            dgvPretragaPredmeta.DataSource = null;
            dgvPretragaPredmeta.DataSource = lista ?? baza.KorisniciPredmeti.ToList();
        }

        private void txtNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //pretraga položenih predmeta po nazivu
                var filter = txtNazivPredmeta.Text.Trim().ToLower();
                var pretraga = baza.KorisniciPredmeti.Where(x => x.Predmet.Naziv
                .Trim().ToLower().Contains(filter)).ToList();

                //prosjek ocjena
                var prosjek = pretraga.Average(x => x.Ocjena);
                if (pretraga != null)
                {
                    if (pretraga.Count == 0)
                        lblProsjekOcjena.Text = "0";
                    else
                        lblProsjekOcjena.Text = prosjek.ToString();
                }
                UcitajPredmete(pretraga);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            var uneseniBrojThread = int.Parse(txtUnosBrojaThread.Text);
            double suma = 0;

            await Task.Run(() =>
            {
                suma = IzracunajSumu(uneseniBrojThread);
            });

            lblSumaThreading.Text = suma.ToString();
        }
        private double IzracunajSumu(int uneseniBrojThread)
        {
            double suma = 0;
            for (int i = 0; i < uneseniBrojThread; i++)
            {
                suma += i;
            }
            return suma;
        }

        private void dgvPretragaPredmeta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                KorisniciPredmeti korisniciPredmeti = dgvPretragaPredmeta.CurrentRow.DataBoundItem as KorisniciPredmeti;

                frmPorukeIB140261 frmPorukeIB140261 = new frmPorukeIB140261(korisniciPredmeti.Korisnik);
                frmPorukeIB140261.Show();
            }
        }
    }
}
