using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<StudentiPredmetiIB140261> studentiPredmeti = null)
        {
            try
            {
                studentiPredmeti = studentiPredmeti ?? _baza.StudentiPredmeti.ToList();
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studentiPredmeti;

                ZaglavnjeForme(studentiPredmeti);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }

        }

        private void ZaglavnjeForme(List<StudentiPredmetiIB140261> studentiPredmeti)
        {
            if (studentiPredmeti.Count() <= 0)
                this.Text = $"Ukupno zapisa: {0}";
            else
                this.Text = $"Ukupno zapisa: {studentiPredmeti.Count()}";
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                return;
            }
            var pretraga = _baza.StudentiPredmeti.Where(x =>
                            (x.Predmet.Naziv.Trim().ToLower().Contains(filter))).ToList();

            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var pitanje = MessageBox.Show("Da li želite izbrisati zapis?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    var obrisi = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmetiIB140261;
                    _baza.StudentiPredmeti.Remove(obrisi);
                    _baza.SaveChanges();
                    LoadData();
                    MessageBox.Show("Zapis obrisan...");
                }
            }

            if (e.ColumnIndex == 5)
            {
                var sourceStudnetiSlike = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmetiIB140261;
                frmStudentiSlikeIB140261 frm = new frmStudentiSlikeIB140261(sourceStudnetiSlike.Student);
                frm.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var sourceIzvjestaj = dgvPretraga.DataSource as List<StudentiPredmetiIB140261>;
            frmIzvjestajIB140261 frm = new frmIzvjestajIB140261(sourceIzvjestaj);
            frm.ShowDialog();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            var Od = int.Parse(txtOD.Text);
            var Do = int.Parse(txtDO.Text);
            double suma = 0;
            await Task.Run(() =>
            {
                for (int i = Od; i < Do; i++)
                {
                    suma += i;
                }

                Action action = () => txtRezultat.Text = $"{Math.Round(suma, 2)}";
                BeginInvoke(action);
            });
        }

        private void btnTeorija_Click(object sender, EventArgs e)
        {
            frmTeorijaIB140261 frm = new frmTeorijaIB140261();
            frm.Show();
        }
    }
}
