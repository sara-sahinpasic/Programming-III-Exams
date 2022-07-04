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
        List<string> samoglasnici = new List<string>()
        {
            "a", "e", "i", "o", "u"
        };
        List<string> znakovi = new List<string>()
        {
            "?","!","<",">","*"
        };
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<Student> studenti = null)
        {
            try
            {
                //dgvPretraga.DataSource = null;
                //dgvPretraga.DataSource = studenti ?? _baza.Studenti.ToList();

                studenti = studenti ?? _baza.Studenti.ToList();
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studenti;

                NajveciProsjek(studenti);
                IzracunajProsjek(studenti);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void IzracunajProsjek(List<Student> studenti)
        {
            double prosjek = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                prosjek += studenti[i].Prosjek;
            }
            prosjek /= studenti.Count();
            lblProsjek.Text = $"Prosjek prikazanih ocjena: {Math.Round(prosjek, 2)}";
        }

        private void NajveciProsjek(List<Student> studenti)
        {
            double max = 0;
            string student = "";
            for (int i = 0; i < studenti.Count; i++)
            {
                if (max < studenti[i].Prosjek)
                {
                    max = studenti[i].Prosjek;
                    student = studenti[i].ImePrezime;
                }
            }
            if (max <= 5)
            {
                lblMaxProsjekOstvario.Text = $"Najveći prosjek ostvario: NOT SET";
            }
            else
            {
                lblMaxProsjekOstvario.Text = $"Najveći prosjek ostvario: {student}";
            }
        }

        //private void LoadData(List<Student> student = null)
        //{
        //    try
        //    {
        //        dgvPretraga.DataSource = null;
        //        dgvPretraga.DataSource = student ?? _baza.Studenti.ToList();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
        //    }
        //}

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            var filter = txtImePrezime.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();

                return;
            }
            var pretraga = _baza.Studenti.Where(x =>
                (x.Ime.Trim().ToLower().Contains(filter)
                || x.Prezime.Trim().ToLower().Contains(filter))).ToList();

            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var source = dgvPretraga.CurrentRow.DataBoundItem as Student;
                frmScanIspitaIB140261 frm = new frmScanIspitaIB140261(source);
                frm.ShowDialog();
            }
        }

        private async void btnGenerisiInfo_Click(object sender, EventArgs e)
        {
            int brojacSamoglasnici = 0;
            int brojacSuglasnici = 0;
            int brojacZnakovi = 0;
            var pretragaUnosa = txtSadrzaj.Text.Trim().ToLower();
            Action action = () => lblSadrzajInfo.Text = $"Samoglasnika: {brojacSamoglasnici} \r\n" +
              $"Suglasnika: {brojacSuglasnici}\r\n" +
              $"Znakova (?,!,<,>,*): {brojacZnakovi}";
            await Task.Run(() =>
            {
                /*
                 var pretraga = _baza.Studenti.Where(x =>
                 (x.Ime.Trim().ToLower().Contains(filter)
                 || x.Prezime.Trim().ToLower().Contains(filter))).ToList();
                 */
                brojacSamoglasnici = pretragaUnosa.Where(x => samoglasnici.Contains(x.ToString())).Count();
                brojacZnakovi = pretragaUnosa.Where(x => znakovi.Contains(x.ToString())).Count();
                brojacSuglasnici = pretragaUnosa.Length - brojacSamoglasnici - brojacZnakovi;
            });
            BeginInvoke(action);
        }

        private void txtSadrzaj_TextChanged(object sender, EventArgs e)
        {
            txtSadrzaj.ScrollBars = ScrollBars.Vertical;
        }
    }
}
