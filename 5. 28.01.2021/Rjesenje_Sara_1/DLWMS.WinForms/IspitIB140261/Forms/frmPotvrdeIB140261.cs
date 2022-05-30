using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IspitIB140261.Class;
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

namespace DLWMS.WinForms.IspitIB140261.Forms
{
    public partial class frmPotvrdeIB140261 : Form
    {
        private KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmPotvrdeIB140261()
        {
            InitializeComponent();
            dgvStudentiPotvrde.AutoGenerateColumns = false;
        }
        private void frmPotvrdeIB140261_Load(object sender, EventArgs e)
        {
            UcitajDGV();
        }

        private void UcitajDGV(List<StudentiPotvrdeIB140261> studentiPotvrde = null)
        {
            try
            {
                dgvStudentiPotvrde.DataSource = null;
                dgvStudentiPotvrde.DataSource = studentiPotvrde ?? _baza.StudentiPotvrde.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private async void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajDGV();
            await Task.Run(() =>
            {
                var brojPotvrda = int.Parse(txtBrojPotvrda.Text);

                StudentiPotvrdeIB140261 noviZapis = new StudentiPotvrdeIB140261();

                Random random = new Random();
                int toSkip = random.Next(1, _baza.Studenti.Count() - 1);

                for (int i = 0; i < brojPotvrda; i++)
                {
                    noviZapis.Student = _baza.Studenti.ToList().ElementAt(toSkip);
                    noviZapis.Datum = DateTime.Now.ToString();
                    noviZapis.Svrha = $"Regulisanje statusa_{i + 1}";
                    noviZapis.Izdata = random.NextDouble() > 0.5;
                    _baza.StudentiPotvrde.Add(noviZapis);
                    _baza.SaveChanges();
                }
                BeginInvoke(action);
                MessageBox.Show("Podaci su dodati!");
            });

        }
        private async void btnObrisiPotvrde_Click(object sender, EventArgs e)
        {
            Action action = () => UcitajDGV();
            await Task.Run(() =>
            {
                var pitnaje = MessageBox.Show("Da li želite obrisati zapis?", "Pitanje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (pitnaje == DialogResult.OK)
                {
                    for (int i = 0; i < dgvStudentiPotvrde.SelectedRows.Count; i++)
                    {
                        var brisanje = dgvStudentiPotvrde.SelectedRows[i].DataBoundItem as StudentiPotvrdeIB140261;
                        _baza.StudentiPotvrde.Remove(brisanje);
                    }
                }
            });
            _baza.SaveChanges();
            BeginInvoke(action);
            MessageBox.Show("Zapis je izbrisan!");
        }

        private void ObrisiPotvrde()
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            SaveCSV(@"potvrdeIB140261.csv");
            MessageBox.Show("Fajl je spašen!");
        }

        private void SaveCSV(string nazivFile)
        {
            using (StreamWriter sw = File.AppendText(nazivFile))
            {
                foreach (var potvrda in _baza.StudentiPotvrde)
                    sw.WriteLine(potvrda.Student + ", " + potvrda.Datum + ", " + potvrda.Svrha + ", " + potvrda.Izdata);

                sw.Close();
            }
        }
    }
}
