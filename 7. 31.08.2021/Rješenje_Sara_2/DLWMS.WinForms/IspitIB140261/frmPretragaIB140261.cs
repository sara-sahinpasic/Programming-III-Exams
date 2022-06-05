using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        List<string> _samoglasnici = new List<string> { "a", "e", "i", "o", "u" };
        List<string> _znakovi = new List<string> { "?", "!", "<", ">", "*" };

        List<int> bbb = new List<int>()
        {
            1,2,3
        };
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load_1(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<StudentiPredmeti> studentiPredmeti = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studentiPredmeti ?? _baza.StudentiPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            string filter = txtImePrezime.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                return;
            }
            var pretraga = _baza.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Trim().Contains(filter)
            || x.Student.Prezime.ToLower().Trim().Contains(filter)).ToList();

            //if (pretraga == null)
            //{
            //    lblProsjekOcjen.Text = $"{0}";
            //    lblStudent.Text = $"NOT SET";
            //}
            //else
            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var x = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmeti;
                frmScanIspitaIB140261 forma = new frmScanIspitaIB140261(x);
                forma.ShowDialog();
            }
        }



        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            Threading();
        }
        private async void Threading()
        {
            var unos = txtSadrzaj.Text.ToLower();
            int brojacSamoglasnika = 0;
            int brojacZankova = 0;
            int brojacSuglasnika = 0;
            Action action = () =>
           {
               lblSamoglasnik.Text = $"{brojacSamoglasnika}";
               lblSuglasnik.Text = $"{brojacSuglasnika}";
               lblZnakovi.Text = $"{brojacZankova}";
           };
            await Task.Run(() =>
            {
                brojacSamoglasnika = unos.Where(x => _samoglasnici.Contains(x.ToString())).Count();
                brojacZankova = unos.Where(x => _znakovi.Contains(x.ToString())).Count();
                brojacSuglasnika = unos.Length - brojacSamoglasnika - brojacZankova;
            });
            BeginInvoke(action);
        }
    }
}
