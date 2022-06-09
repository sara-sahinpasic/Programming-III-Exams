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
    public partial class frmKonsultacije : Form
    {
        // private StudentiPredmeti _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private Student _x;

        public frmKonsultacije()
        {
            InitializeComponent();
            dgvKonsultacije.AutoGenerateColumns = false;
        }

        
        public frmKonsultacije(Student x) : this()
        {
            this._x = x;
        }

        private void frmKonsultacije_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"Lista zahtjeva za konsultacije sa studentom {_x.ImePrezime}";
            LoadData();
            LoadCMB();
        }

        private void LoadCMB()
        {
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.DataSource = _baza.Predmeti.ToList();
        }

        private void LoadData(List<StudentiKonsultacije> studentiKonsultacije = null)
        {
            try
            {
                dgvKonsultacije.DataSource = null;
                dgvKonsultacije.DataSource = studentiKonsultacije ?? _baza.StudentiKonsultacije.Where(x => x.Student.Id == _x.Id).ToList();

                
                var brojZapisa = _baza.StudentiKonsultacije.Where(x => x.Student.Id == _x.Id).ToList().Count();

                if (brojZapisa <= 0)
                    this.Text = $"Broj prikazanih zapisa: {0}";
                else
                    this.Text = $"Broj prikazanih zapisa: {brojZapisa}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message }{Environment.NewLine }{ex.InnerException?.Message }");
            }
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            //var x = dgvKonsultacije.DataSource as StudentiKonsultacije;
            var x = dgvKonsultacije.CurrentRow.DataBoundItem as StudentiKonsultacije;
            frmNovaKonsultacija forma = new frmNovaKonsultacija(x);
            forma.ShowDialog();
            LoadData();
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var brojZahtjeva = int.Parse(txtBrojZahtjeva.Text);
            var odabirPredmeta = cmbPredmet.SelectedItem as Predmeti;
            var napomena = txtInfo.Text;

            await Task.Run(() =>
            {
                for (int i = 0; i < brojZahtjeva; i++)
                {
                    Thread.Sleep(500);
                    StudentiKonsultacije noviZapis = new StudentiKonsultacije()
                    {
                        Student = _x,
                        Predmet = odabirPredmeta,
                        VrijemeOdrzavanja = DateTime.Now,
                        Napomena = txtInfo.Text //prvi prelaz student nema napomenu
                    };
                    _baza.StudentiKonsultacije.Add(noviZapis);

                    Action action = () => txtInfo.Text += $"Za {noviZapis.Student.Ime} {noviZapis.Student.Prezime} dodat zahtjev za konsultacijama -> " +
                    $"{noviZapis.Predmet} ({noviZapis.VrijemeOdrzavanja}) {Environment.NewLine}";
                    BeginInvoke(action);
                }
                _baza.SaveChanges();
            });
            MessageBox.Show("Novi zahtjevi dodani.");
            LoadData();
        }
        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var pitanje = MessageBox.Show("" +
                    "Da li želite izbrisati zapis?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                var trenutnoVrijeme = DateTime.Now;
                var trenutniElement = dgvKonsultacije.CurrentRow.DataBoundItem as StudentiKonsultacije;

                if (pitanje == DialogResult.OK && trenutniElement.VrijemeOdrzavanja >= trenutnoVrijeme)
                {
                    _baza.StudentiKonsultacije.Remove(trenutniElement);
                    _baza.SaveChanges();
                    LoadData();
                    MessageBox.Show("Zapis izbrisan.");
                }
                else
                    MessageBox.Show("Zapis nije obrisan.");
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvKonsultacije.DataSource as List<StudentiKonsultacije>;
            frmIzvjestaj forma = new frmIzvjestaj(x);
            forma.Show();
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

