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

namespace cSharpIntroWinForms.IspitIB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMS.DB;
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            ///Pretraga();
        }

        private void LoadData(List<KorisniciPredmeti> korisniciPredmeti = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = korisniciPredmeti ?? _baza.KorisniciPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void txtPredmet_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPredmet.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                return;
            }
            var pretraga = _baza.KorisniciPredmeti.Where(x => x.Predmet.Naziv.ToLower().Trim().Contains(filter)).ToList();

            if (pretraga.Count == 0)
                lblProsjek.Text = $"Prosjek prikazanih ocjena je: {0}";
            else
            {
                int suma = 0;
                double prosjek = 0;
                for (int i = 0; i < pretraga.Count; i++)
                {
                    suma += pretraga[i].Ocjena;
                }
                prosjek = suma / pretraga.Count;
                lblProsjek.Text = $"Prosjek prikazanih ocjena je: {prosjek}";
            }
            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var x = dgvPretraga.CurrentRow.DataBoundItem as KorisniciPredmeti;
                frmPorukeIB140261 forma = new frmPorukeIB140261(x);
                forma.ShowDialog();
            }
        }

        private async void btnSuma_Click(object sender, EventArgs e)
        {
            var unos = int.Parse(txtThreading.Text);
            double suma = 0;
            await Task.Run(() =>
            {
                suma = IzracunajSumu(unos);
            });
            lblThreadingSuma.Text = $"{suma}";
        }

        private double IzracunajSumu(int unos)
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
