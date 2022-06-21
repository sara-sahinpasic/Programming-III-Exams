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
            dgvPotvrde.DataSource = null;
            dgvPotvrde.DataSource = studentiPotvrde ?? _baza.StudentiPotvrde.ToList();
        }

        private async void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            var unosBroja = int.Parse(txtBrojPotvrda.Text);
            Action action = () => LoadData();
            await Task.Run(() =>
            {
                GenerisiPotvrde(unosBroja);
            });
            BeginInvoke(action);
            MessageBox.Show("Zapisi pohranjeni!");
        }

        private void GenerisiPotvrde(int unosBroja)
        {
            Random random = new Random();
            var brojStudenata = _baza.Studenti.ToList().Count();

            int regulisanjeStatusa = 1;

            for (int i = 0; i < unosBroja; i++)
            {
                StudentiPotvrdeIB140261 noviZapis = new StudentiPotvrdeIB140261();
                noviZapis.Student = _baza.Studenti.ToList().ElementAt(random.Next(0, brojStudenata));
                noviZapis.Datum = DateTime.Now.ToString("G");
                noviZapis.Svrha = $"Regulisanje statusa_{regulisanjeStatusa++}";
                noviZapis.Izdata = random.NextDouble() > 0.5;

                _baza.StudentiPotvrde.Add(noviZapis);
            }
            _baza.SaveChanges();
        }

        private async void btnObrisiPotvrde_Click(object sender, EventArgs e)
        {
            var pitanje = MessageBox.Show(
                "Da li ste sigurni da želite obrisati sve podatke o potvrdama ?",
                "Pitanje",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            Action action = () => LoadData();
            await Task.Run(() =>
            {
                if (pitanje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvPotvrde.Rows.Count; i++)
                    {
                        var brisi = dgvPotvrde.Rows[i].DataBoundItem as StudentiPotvrdeIB140261;
                        _baza.StudentiPotvrde.Remove(brisi);
                    }
                    _baza.SaveChanges();
                }
            });
            BeginInvoke(action);
            MessageBox.Show("Zapisi izbrisani!");
        }

        private void btnSpasiUFajl_Click(object sender, EventArgs e)
        {
            SaveCSV(@"potvrdeIB140261.csv");
            MessageBox.Show("Fajl je sačuvan!");
        }

        private void SaveCSV(string v)
        {
            using (StreamWriter sw = File.AppendText(v))
            {
                foreach (var potvrda in _baza.StudentiPotvrde)
                {
                    sw.WriteLine(
                        potvrda.Student + ", " +
                        potvrda.Datum + ", " +
                        potvrda.Svrha + ", " +
                        potvrda.Izdata);
                }
                sw.Close();
            }
        }
    }
}

