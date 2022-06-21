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
    public partial class frmCovidTestIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        List<string> rezultatiTesta = new List<string>()
        {
            "Negativan", "Pozitivan"
        };
        public frmCovidTestIB140261()
        {
            InitializeComponent();
            dgvTestovi.AutoGenerateColumns = false;

        }

        private void frmCovidTestIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCMB();
            lblBrojTestova.Text = $"Broj testova: {_baza.StudentiCovidTestovi.ToList().Count()}";
        }

        private void LoadCMB()
        {
            cmbStudneti.ValueMember = "Id";
            cmbStudneti.DisplayMember = "Naziv";
            cmbStudneti.DataSource = _baza.Studenti.ToList();

            cmbRezultatiTesta.DataSource = rezultatiTesta;
        }

        private void LoadData(List<StudentiCovidTestoviIB140261> studentiCovidTestovi = null)
        {
            dgvTestovi.DataSource = null;
            dgvTestovi.DataSource = studentiCovidTestovi ?? _baza.StudentiCovidTestovi.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var student = cmbStudneti.SelectedItem as Student;
            var datum = dtpDatum.Value;
            var rezultat = cmbRezultatiTesta.SelectedItem;
            var dostavljenNalaz = cbNalazDostavljen.Checked;

            var listaTestovaOdabranogStudenta = _baza.StudentiCovidTestovi.Where(x => x.Student.Id == student.Id).ToList();
            bool testNaOdabraniDatumPostoji = false;
            for (int i = 0; i < listaTestovaOdabranogStudenta.Count; i++)
            {
                if (listaTestovaOdabranogStudenta[i].Datum.Date == datum.Date)
                {
                    testNaOdabraniDatumPostoji = true;
                    break;
                }
            }

            if (testNaOdabraniDatumPostoji == false)
            {
                StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261();
                noviZapis.Student = student;
                noviZapis.Datum = datum;
                noviZapis.Rezultat = rezultat.ToString();
                noviZapis.NalazDostavljen = dostavljenNalaz;

                _baza.StudentiCovidTestovi.Add(noviZapis);
                _baza.SaveChanges();

                MessageBox.Show("Rezultat je sačuvan!");
                LoadData();
                lblBrojTestova.Text = $"Broj testova: {_baza.StudentiCovidTestovi.ToList().Count()}";
            }
            else
            {
                MessageBox.Show("Danas je već unesen rezultat testa!");
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var unos = int.Parse(txtBrojTestova.Text);
            Action action = () => LoadData();
            await Task.Run(() =>
            {
                Random random = new Random();

                for (int i = 0; i < unos; i++)
                {
                    int brojStudenata = _baza.Studenti.Count();
                    var student = _baza.Studenti.ToList().ElementAt(random.Next(0, brojStudenata - 1));
                    var datum = DateTime.Now;
                    var rezultat = random.NextDouble() > 0.5 ? "Pozitivan" : "Negativan";
                    var dostavljen = random.NextDouble() > 0.5;

                    StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261();
                    noviZapis.Student = student;
                    noviZapis.Datum = datum;
                    noviZapis.Rezultat = rezultat;
                    noviZapis.NalazDostavljen = dostavljen;

                    _baza.StudentiCovidTestovi.Add(noviZapis);
                }
                _baza.SaveChanges();
            });
            BeginInvoke(action);
            MessageBox.Show($"Broj od {unos} zapisa je dodan!");

        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var pitanje = MessageBox.Show(
                    "Da li ste sigurni da želite obrisati sve podatke o COVID testovima?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

            Action action = () => LoadData();
            await Task.Run(() =>
            {

                if (pitanje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvTestovi.Rows.Count; i++)
                    {
                        var brisi = dgvTestovi.Rows[i].DataBoundItem as StudentiCovidTestoviIB140261;
                        _baza.StudentiCovidTestovi.Remove(brisi);
                    }
                    _baza.SaveChanges();
                }
            });
            BeginInvoke(action);
            MessageBox.Show("Zapisi su obrisani!");
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvTestovi.DataSource as List<StudentiCovidTestoviIB140261>;
            frmIzvjestaji forma = new frmIzvjestaji(x);
            forma.Show();
        }
    }
}
