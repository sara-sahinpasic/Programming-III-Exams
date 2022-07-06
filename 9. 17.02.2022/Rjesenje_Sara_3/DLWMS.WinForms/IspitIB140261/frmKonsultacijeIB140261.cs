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

namespace DLWMS.WinForms.IspitIB140261
{
    public partial class frmKonsultacijeIB140261 : Form
    {
        private Student _sourceStudnet;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmKonsultacijeIB140261()
        {
            InitializeComponent();
            dgvKonsultacije.AutoGenerateColumns = false;
        }

        public frmKonsultacijeIB140261(Student source) : this()
        {
            this._sourceStudnet = source;
        }

        private void frmKonsultacijeIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.DataSource = _baza.Predmeti.ToList();
        }

        private void LoadData(List<StudnetiKonsultacijeIB140261> studnetiKonsultacije = null)
        {
            studnetiKonsultacije = studnetiKonsultacije ?? _baza.StudentiKonsultacije.Where(x => x.Student.Id == _sourceStudnet.Id).ToList();
            dgvKonsultacije.DataSource = null;
            dgvKonsultacije.DataSource = studnetiKonsultacije;

            IzgledForme(studnetiKonsultacije);
        }

        private void IzgledForme(List<StudnetiKonsultacijeIB140261> studnetiKonsultacije)
        {
            if (studnetiKonsultacije.Count() == 0)
                this.Text = $"Broj prikazanih zapisa: {0}";
            else
                this.Text = $"Broj prikazanih zapisa: {studnetiKonsultacije.Count()}";

            lblStudentKonsultacije.Text = $"Lista prikazanih zahtjeva za: {_sourceStudnet.ImePrezime}";
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            var brojZahjteva = int.Parse(txtBrojZahtjeva.Text);
            var predmet = cmbPredmeti.SelectedItem as PredmetiIB140261;
            var student = _sourceStudnet;
            var datum = DateTime.Now;
            await Task.Run(() =>
            {
                for (int i = 0; i < brojZahjteva; i++)
                {
                    StudnetiKonsultacijeIB140261 noviZapis = new StudnetiKonsultacijeIB140261();
                    noviZapis.Student = student;
                    noviZapis.Predmet = predmet;
                    noviZapis.VrijemeOdrzavanja = datum;
                    noviZapis.Napomena = $"Konsultacije vezane za posljedni ispit iz predmeta {predmet}, na datum {datum}";


                    _baza.StudentiKonsultacije.Add(noviZapis);

                    Thread.Sleep(500);
                    Action action = () => txtInfo.Text += $"Za {student.ImePrezime} dodat zahjtev za konsultacijama -> " +
                $"{predmet} ({datum}) {Environment.NewLine}";
                    BeginInvoke(action);
                }
                _baza.SaveChanges();
            });
            LoadData();
            MessageBox.Show("Zapisi dodani...");
        }

        private void dgvKonsultacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var pitanje = MessageBox.Show("Da li želite izbrisati zapis?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                //var listaStudenata = _baza.StudentiKonsultacije.Where(x => x.Student.Id == _sourceStudnet.Id).ToList();
                //bool datumKonsultacijeBuducnost = false;
                //for (int i = 0; i < listaStudenata.Count; i++)
                //{
                //    if (listaStudenata[i].VrijemeOdrzavanja.Date == trenutniDatum.Date)
                //    {
                //        datumKonsultacijeBuducnost = true;
                //        break;
                //    }
                //}

                var trenutniDatum = DateTime.Now;
                var datumKonsultacijaStudenta = dgvKonsultacije.CurrentRow.DataBoundItem as StudnetiKonsultacijeIB140261;
                if (pitanje == DialogResult.OK && datumKonsultacijaStudenta.VrijemeOdrzavanja >= trenutniDatum)
                {
                    var obrisi = dgvKonsultacije.CurrentRow.DataBoundItem as StudnetiKonsultacijeIB140261;
                    _baza.StudentiKonsultacije.Remove(obrisi);
                    _baza.SaveChanges();
                    LoadData();
                    MessageBox.Show("Zapis obrisan...");
                }
                else
                    MessageBox.Show("Zapis nije obrisan jer je konsultacija već realizovana...");
            }

        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source = dgvKonsultacije.DataSource as List<StudnetiKonsultacijeIB140261>;
            frmIzvjestajIB140261 frm = new frmIzvjestajIB140261(source);
            frm.Show();
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            //var source=dgvKonsultacije.DataSource as 
            frmNovaKonsultcijaIB140261 frm = new frmNovaKonsultcijaIB140261(_sourceStudnet);
            frm.ShowDialog();
            LoadData();
        }
    }
}
