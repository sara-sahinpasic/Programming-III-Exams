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

namespace DLWMS.WinForms.IspitIB140261
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


        private void LoadData(List<StudentiPredmetiIB140261> studentiPredmetiIB140261 = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studentiPredmetiIB140261 ?? _baza.StudentiPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
            this.Text = $"Ukupno zapisa: {_baza.StudentiPredmeti.Count()}";

        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void Pretraga()
        {
            var filter = txtPretraga.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filter))
            {
                LoadData();
                this.Text = $"Ukupno zapisa: {_baza.StudentiPredmeti.Count()}";
                return;
            }
            var pretraga = _baza.StudentiPredmeti.Where(x => x.Predmeti.Naziv.Trim().ToLower().Contains(filter)).ToList();

            LoadData(pretraga);
            this.Text = $"Ukupno zapisa: {pretraga.Count()}";
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var pitanje = MessageBox.Show(
                    "Da li želite izbrisati predmet?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    var obrisi = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmetiIB140261;
                    _baza.StudentiPredmeti.Remove(obrisi);
                    _baza.SaveChanges();
                    MessageBox.Show("Odabrani predmet je obrisan!");
                    LoadData();
                }
            }
            else if (e.ColumnIndex == 5)
            {
                var source = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmetiIB140261;
                frmStudnetiSlikeIB140261 formaSlike = new frmStudnetiSlikeIB140261(source);
                formaSlike.ShowDialog();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source = dgvPretraga.DataSource as List<StudentiPredmetiIB140261>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(source);
            forma.Show();
        }

        private async void btnSumiraj_Click(object sender, EventArgs e)
        {
            var UnosOd = int.Parse(txtUnosOd.Text);
            var UnosDo = int.Parse(txtUnosDo.Text);
            double suma = 0;
            Action action = () => txtRezultat.Text = $"{suma}";
            await Task.Run(() =>
            {
                suma = IzracunajSumu(UnosOd, UnosDo);
            });
            BeginInvoke(action);
        }

        private double IzracunajSumu(int unosOd, int unosDo)
        {
            double suma = 0;
            for (int i = unosOd; i < unosDo; i++)
            {
                suma += i;
            }
            return Math.Round(suma,2);
        }
    }
}
