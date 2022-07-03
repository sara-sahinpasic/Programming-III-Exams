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
            "Pozitivan", "Negativan"
        };
        public frmCovidTestIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmCovidTestIB140261_Load(object sender, EventArgs e)
        {
            LoadStudente();
            LoadRezultate();
            LoadData();
        }

        private void LoadData(List<StudentiCovidTestoviIB140261> studentiCovid = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studentiCovid ?? _baza.StudentiCovidTestovi.ToList();

                lblBrojTestova.Text = $"Broj testova: {_baza.StudentiCovidTestovi.Count()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}"); ;
            }
        }

        private void LoadRezultate()
        {
            cmbRezultatTesta.DataSource = null;
            cmbRezultatTesta.DataSource = rezultatiTesta;
        }

        private void LoadStudente()
        {
            cmbStudneti.DataSource = null;
            cmbStudneti.DataSource = _baza.Studenti.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var student = cmbStudneti.SelectedItem as Student;
            var datum = dtpDatum.Value;
            var rezultat = cmbRezultatTesta.SelectedItem.ToString();
            var nalazDostavljen = cbNalazDostavljen.Checked;

            var listaIstihDatumaStudenta = _baza.StudentiCovidTestovi.Where(x => x.Studenti.Id == student.Id).ToList();
            bool datumPostoji = false;
            for (int i = 0; i < listaIstihDatumaStudenta.Count; i++)
            {
                if (listaIstihDatumaStudenta[i].Datum.Date == datum.Date)
                {
                    datumPostoji = true;
                    break;
                }
            }
            if (datumPostoji == false)
            {
                StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261();
                noviZapis.Studenti = student;
                noviZapis.Datum = datum;
                noviZapis.Rezultat = rezultat;
                noviZapis.NalazDostavljen = nalazDostavljen;

                _baza.StudentiCovidTestovi.Add(noviZapis);
                _baza.SaveChanges();
                LoadData();
                MessageBox.Show("Novi test je dodan!");
            }
            else
                MessageBox.Show("Na datum studnet već posjeduje rezultate testa unešene!");

        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var broj = int.Parse(txtBrojTestova.Text);
            Random random = new Random();

            await Task.Run(() =>
            {
                for (int i = 0; i < broj; i++)
                {
                    StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261();
                    noviZapis.Studenti = _baza.Studenti.ToList().ElementAt(random.Next(0, _baza.Studenti.Count() - 1));
                    noviZapis.Datum = DateTime.Now;
                    noviZapis.Rezultat = random.NextDouble() > 0.5 ? "Pozitivan" : "Negativan";
                    noviZapis.NalazDostavljen = random.NextDouble() > 0.5;

                    _baza.StudentiCovidTestovi.Add(noviZapis);
                }
                _baza.SaveChanges();
                Action action = () => LoadData();
                BeginInvoke(action);
            });
            MessageBox.Show("Novi test je dodan!");
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var pitanje = MessageBox.Show("Da li ste sigurni da želite obrisati sve podatke o COVID testovima",
                "Pitanje",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            await Task.Run(() =>
            {
                if (pitanje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvPretraga.Rows.Count; i++)
                    {
                        var obrisi = dgvPretraga.Rows[i].DataBoundItem as StudentiCovidTestoviIB140261;
                        _baza.StudentiCovidTestovi.Remove(obrisi);
                    }
                    _baza.SaveChanges();
                    Action action = () => LoadData();
                    BeginInvoke(action);
                }
            });
            MessageBox.Show("Izbrisano...");
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source = dgvPretraga.DataSource as List<StudentiCovidTestoviIB140261>;
            frmIzvjestaj frm = new frmIzvjestaj(source);
            frm.Show();

        }
    }
}
