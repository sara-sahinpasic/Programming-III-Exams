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
            Load_Data();
        }

        private void Load_Data(List<StudentiPredmeti> studentiPredmeti = null)
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

        private void txtNazivPredmeta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = txtNazivPredmeta.Text.ToLower().Trim();

                if (string.IsNullOrEmpty(filter))
                {
                    Load_Data();
                    var rezultatL = _baza.StudentiPredmeti.Count();
                    this.Text = $"Ukupno zapisa: {rezultatL}";
                    return;
                }
                var pretraga = _baza.StudentiPredmeti.Where(x => x.Predmeti.Naziv.ToString().ToLower().Trim()
                .Contains(filter)).ToList();

                Load_Data(pretraga);
                var rezultat = pretraga.Count;
                this.Text = $"Ukupno zapisa: {rezultat}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)//brisi
            {
                var pitanje = MessageBox.Show($"Da li želite izbrisati zapis?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    var brisi = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmeti;
                    _baza.StudentiPredmeti.Remove(brisi);
                    _baza.SaveChanges();
                    Load_Data();
                }
            }
            else if (e.ColumnIndex == 5) //slike
            {
                var x = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmeti;
                frmStudentiSlikeIB140261 forma = new frmStudentiSlikeIB140261(x);
                forma.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvPretraga.DataSource as List<StudentiPredmeti>;

            if (x?.Count > 0)
            {
                frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
                forma.Show();
            }
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            int suma = 0;
            await Task.Run(() =>
            {
                var unosOd = int.Parse(txtOd.Text);
                var unosDo = int.Parse(txtDo.Text);
                for (int i = unosOd; i < unosDo; i++)
                {
                    suma += i;
                }
            });
            Action action = () => txtSuma.Text = $"{suma}";
            BeginInvoke(action);
        }

        private void txtTeorija_Click(object sender, EventArgs e)
        {
            frmTeorijaIB140261 forma = new frmTeorijaIB140261();
            forma.Show();
        }
    }
}
