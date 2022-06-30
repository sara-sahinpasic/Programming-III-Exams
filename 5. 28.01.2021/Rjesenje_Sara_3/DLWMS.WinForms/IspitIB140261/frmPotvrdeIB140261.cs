using DLWMS.WinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IspitIB140261
{
    public partial class frmPotvrdeIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPotvrdeIB140261()
        {
            InitializeComponent();
            dgvPotvrde.AutoGenerateColumns = false;
        }

        private void frmPotvrdeIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<StudentiPotvrdeIB140261> studentiPotvrde = null)
        {
            try
            {
                dgvPotvrde.DataSource = null;
                dgvPotvrde.DataSource = studentiPotvrde ?? _baza.StudentiPotvrde.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            var broj = int.Parse(txtUnosBroja.Text);
            var studnetiLista = _baza.Studenti.ToList();
            Random random = new Random();

            await Task.Run(() =>
            {
                for (int i = 0; i < broj; i++)
                {
                    StudentiPotvrdeIB140261 noviZapis = new StudentiPotvrdeIB140261();
                    noviZapis.Studenti = _baza.Studenti.ToList().ElementAt(random.Next(1, studnetiLista.Count()));
                    noviZapis.Datum = DateTime.Now.ToString("G");
                    noviZapis.Svrha = $"Regulisanje statusa_{i + 1}";
                    noviZapis.Izdata = random.NextDouble() > 0.5;

                    _baza.StudentiPotvrde.Add(noviZapis);
                }
                _baza.SaveChanges();
                Action action = () => LoadData();
                BeginInvoke(action);
            });
            MessageBox.Show("Potvrde generisane!");
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            var pitanje = MessageBox.Show("Da li ste sigurni da želite obrisati sve podatke o potvrdama",
                "Pitanje",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            await Task.Run(() =>
            {
                if (pitanje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvPotvrde.Rows.Count; i++)
                    {
                        var obrisi = dgvPotvrde.Rows[i].DataBoundItem as StudentiPotvrdeIB140261;
                        _baza.StudentiPotvrde.Remove(obrisi);
                    }
                    _baza.SaveChanges();
                    Action action = () => LoadData();
                    BeginInvoke(action);
                }
            });
            MessageBox.Show("Zapisi obrisani!");
        }

        private void btnSpasiFile_Click(object sender, EventArgs e)
        {
            SaveCSV(@"potvrdeIB140261.csv");
            MessageBox.Show("File sacuvan!"); ;
        }

        private void SaveCSV(string v)
        {
            using (StreamWriter sw = File.AppendText(v))
            {
                foreach (var x in _baza.StudentiPotvrde)
                {
                    sw.WriteLine(
                     x.Studenti + " " + x.Datum + " " + x.Svrha + " " + x.Izdata);
                }
                sw.Close();
            }
        }
    }
}

