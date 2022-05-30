using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB140261.Report;
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
    public partial class frmCovidTestIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmCovidTestIB140261()
        {
            InitializeComponent();
            dgvCovid.AutoGenerateColumns = false;
            UcitajStudente();
            UcitajDGV();
        }

        private void UcitajDGV()
        {
            try
            {
                dgvCovid.DataSource = null;
                dgvCovid.DataSource = _baza.StudentiCovidTestovi.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void UcitajStudente()
        {
            cmbStudenti.ValueMember = "Id";
            cmbStudenti.DisplayMember = "Naziv";
            cmbStudenti.DataSource = _baza.Studenti.ToList();
        }

       
        private void btnDodaj_Click(object sender, EventArgs e)
        {


            try
            {
               // if (ProvjeriDatum())
               // {
                    var student = cmbStudenti.SelectedItem;
                    var rezultat = cmbRezultati.SelectedItem.ToString();
                    var dostavljen = cbNalazDostavljen.Checked;
                    var datum = dtpDatum.Value;

                    StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261();

                    noviZapis.Student = student as Student;
                    noviZapis.Datum = datum;
                    noviZapis.Rezultat = rezultat;
                    noviZapis.NalazDostavljen = dostavljen;

                    _baza.StudentiCovidTestovi.Add(noviZapis);
                    _baza.SaveChanges();
                    MessageBox.Show("Rezultat testa dodan!");
                    UcitajDGV();
                //}
                //else
                //{
                //    MessageBox.Show("Nemoguće dodati 2 rezultata na isti dan!");
                //    return;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");

            }
        }

        private bool ProvjeriDatum()
        {
            var datum = dtpDatum.Value;
            var datumBaza = _baza.StudentiCovidTestovi.FirstOrDefault(x => x.Datum == datum);

            return datumBaza != null;
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var unosBroja = int.Parse(txtBrojTestova.Text);
            Action action = () => UcitajDGV();
            await Task.Run(() =>
            {


                Random randomStudent = new Random();
                int indexStudent = randomStudent.Next(1, _baza.Studenti.Count() - 1);

                Random randomRezultat = new Random();
                Random randomNalaz = new Random();


                for (int i = 0; i < unosBroja; i++)

                {
                    StudentiCovidTestoviIB140261 noviZapis = new StudentiCovidTestoviIB140261()
                    {
                        Student = _baza.Studenti.ToList().ElementAt(indexStudent),
                        Datum = DateTime.Now,
                        Rezultat = randomRezultat.NextDouble() > 0.5 ? "Negativan" : "Pozitivan",
                        NalazDostavljen = randomNalaz.NextDouble() > 0.5
                    };
                    _baza.StudentiCovidTestovi.Add(noviZapis);
                }
            });
            _baza.SaveChanges();
            BeginInvoke(action);
            MessageBox.Show($"Uspješno generisano {unosBroja} rezultata COVID testiranja");
        }

        private async void btnBrisi_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajDGV();
            await Task.Run(() => 
            {
                DialogResult pitanje = MessageBox.Show(
                   "Da li želite obrisati zapis(e)?",
                   "Pitanje",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvCovid.SelectedRows.Count; i++)
                    {
                        var izbrisani = dgvCovid.SelectedRows[i].DataBoundItem as StudentiCovidTestoviIB140261;
                        _baza.StudentiCovidTestovi.Remove(izbrisani);
                    }
                    
                }
            });
            _baza.SaveChanges();
            BeginInvoke(action);
            MessageBox.Show($"Izbrisano {dgvCovid.SelectedRows.Count} zapisa.");
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var izvjestaj = dgvCovid.DataSource as List<StudentiCovidTestoviIB140261>;
            frmIzvjestajIB140261 frmIzvjestajIB140261 = new frmIzvjestajIB140261(izvjestaj);
            frmIzvjestajIB140261.ShowDialog();
        }

        private void frmCovidTestIB140261_Load(object sender, EventArgs e)
        {

        }
    }
}
