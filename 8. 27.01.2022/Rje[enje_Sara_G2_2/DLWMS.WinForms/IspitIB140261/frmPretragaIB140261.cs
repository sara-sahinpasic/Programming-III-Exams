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
        List<int> ocjene = new List<int>()
        {
            6, 7, 8, 9, 10
        };

        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            this.Text = $"Ukupno zapisa: {_baza.StudentiPredmeti.Count()}";
            LoadData();
            LoadCmb();
        }

        private void LoadCmb()
        {
            cmbOcjena.DataSource = ocjene;

            cmbStudent.DataSource = null;
            cmbStudent.DataSource = _baza.Studenti.ToList();
        }

        private void LoadData(List<StudentiPredmetiIB140261> studentiPredmeti = null)
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

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var filterOcjena = int.Parse(cmbOcjena.SelectedItem.ToString());
            var pretraga = _baza.StudentiPredmeti.Where(x => x.Ocjena >= filterOcjena).ToList();

            if (pretraga.Count() <= 0)
            {
                LoadData();
                return;
            }

            this.Text = $"Ukupno zapisa: {pretraga.Count()}";
            LoadData(pretraga);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source = dgvPretraga.DataSource as List<StudentiPredmetiIB140261>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(source);
            forma.ShowDialog();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var source = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmetiIB140261;
                frmStudentSeminarskiIB140261 forma = new frmStudentSeminarskiIB140261(source);
                forma.ShowDialog();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var unos = int.Parse(txtOcjena.Text);
            var student = cmbStudent.SelectedItem as Student;


            await Task.Run(() =>
            {
                Random random = new Random();
                for (int i = 0; i < unos; i++)
                {
                    var predmeti = _baza.Predmeti.ToList().ElementAt(random.Next(1, _baza.Predmeti.Count()));
                    var ocjena = random.Next(6, 11);

                    StudentiPredmetiIB140261 noviZapis = new StudentiPredmetiIB140261();
                    noviZapis.Studenti = student;
                    noviZapis.Predmeti = predmeti;
                    noviZapis.Ocjena = ocjena;
                    noviZapis.DatumPolaganja = DateTime.Now.ToString("G");

                    _baza.StudentiPredmeti.Add(noviZapis);

                    Action action = () => txtInfo.Text += $"Za {student.Ime} {student.Prezime} dodat polozeni -> {predmeti} ({ocjena}) {Environment.NewLine}";
                    BeginInvoke(action);
                }
                _baza.SaveChanges();
            });
            MessageBox.Show("Zapisi dodani!");
            LoadData();
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            txtInfo.ScrollBars = ScrollBars.Vertical;
        }
    }
}
