using DLWMS.WinForms.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<int> Ocjene = new List<int>()
        {
            6,7,8,9,10
        };
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbOcjene.DataSource = Ocjene;
            cmbStudenti.DataSource = _baza.Studenti.ToList();
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

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var filter = int.Parse(cmbOcjene.SelectedItem.ToString());
            var pretraga = _baza.StudentiPredmeti.Where(x => x.Ocjena >= filter).ToList();

            var ukupnoZapisa = pretraga.Count;
            if (ukupnoZapisa > 0)
                this.Text = $"Ukupno zapisa: {ukupnoZapisa}";
            else
                this.Text = $"Ukupno zapisa: {0}";

            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var x = dgvPretraga.CurrentRow.DataBoundItem as StudentiPredmeti;
                frmStudentSeminarskiIB140261 forma = new frmStudentSeminarskiIB140261(x);
                forma.ShowDialog();
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var student = cmbStudenti.SelectedItem as Student;
            var unosBrojaOcjena = int.Parse(txtUnosBrojaOcjena.Text);
            await Task.Run(() =>
            {
                Random random = new Random();
                for (int i = 0; i < unosBrojaOcjena; i++)
                {
                    Thread.Sleep(500); //uspavljivanje thread-a
                    StudentiPredmeti noviZapis = new StudentiPredmeti()
                    {
                        Student = student,
                        Ocjena = random.Next(5, 11),
                        Predmet = _baza.Predmeti.ToList().ElementAt(random.Next(1, 4)),
                        DatumPolaganja = DateTime.Now.ToString()
                    };
                    _baza.StudentiPredmeti.Add(noviZapis);
                    Action action = () => txtInfo.Text += $"Za {student} dodat položeni -> {noviZapis.Predmet} ({noviZapis.Ocjena}){Environment.NewLine}";
                    BeginInvoke(action);
                }
                _baza.SaveChanges();
            });
            LoadData();
            MessageBox.Show("Dodavanje uspješno!");
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvPretraga.DataSource as List<StudentiPredmeti>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
            forma.Show();
        }

        private void btnTeorija_Click(object sender, EventArgs e)
        {
            frmTeorijaIB140261 forma = new frmTeorijaIB140261();
            forma.Show();
        }
    }
}
