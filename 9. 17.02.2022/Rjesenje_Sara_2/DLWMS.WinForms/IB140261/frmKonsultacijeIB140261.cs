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
    public partial class frmKonsultacijeIB140261 : Form
    {
        private Student _source;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmKonsultacijeIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        public frmKonsultacijeIB140261(Student source) : this()
        {
            this._source = source;
        }

        private void frmKonsultacijeIB140261_Load(object sender, EventArgs e)
        {
            lblListaKonsultacijeStudnet.Text = $"Lista zahjtvea za studenta {_source.ImePrezime}";
            //int brojZahjteva = _baza.StudentiKonsultacije.Count();
            //if (brojZahjteva <= 0)
            //    this.Text = $"Broj prikazanih zapisa: {0}";
            //else
            //    this.Text = $"Broj prikazanih zapisa: {brojZahjteva}";

            LoadCmb();
            LoadData();

        }

        private void LoadData(List<StudentiKonsultacijeIB140261> studentiKonsultacije = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studentiKonsultacije ?? _baza.StudentiKonsultacije.Where(x=>x.Studenti.Id==_source.Id).ToList();

                /*OVDJE LOAD-ati ime forme*/
                // int brojZahjteva = _baza.StudentiKonsultacije.Count();
                int brojZahtjeva = _baza.StudentiKonsultacije.Where(x => x.Studenti.Id == _source.Id).ToList().Count();
                if (brojZahtjeva <= 0)
                    this.Text = $"Broj prikazanih zapisa: {0}";
                else
                    this.Text = $"Broj prikazanih zapisa: {brojZahtjeva}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void LoadCmb()
        {
            cmbPredmeti.DataSource = null;
            cmbPredmeti.DataSource = _baza.Predmeti.ToList();
        }

        private void btnDodajZahtjev_Click(object sender, EventArgs e)
        {
            var source = dgvPretraga.CurrentRow.DataBoundItem as StudentiKonsultacijeIB140261;
            frmNovaKonsultacijaIB140261 forma = new frmNovaKonsultacijaIB140261(source);
            forma.ShowDialog();
            //MessageBox.Show("Konsultacija dodana!");
            LoadData();
           // int brojZahjtevaForma = _baza.StudentiKonsultacije.Count();
           // this.Text = $"Broj prikazanih zapisa: {brojZahjtevaForma}";
        }

        private async void btnDodajTh_Click(object sender, EventArgs e)
        {
            var brojZahjteva = int.Parse(txtBrojZahtjeva.Text);
            var predmet = cmbPredmeti.SelectedItem as PredmetiIB140261;
            var student = _source;
            var info = txtInfo.Text;
            var vrijeme = DateTime.Now;

            await Task.Run(() =>
            {
                for (int i = 0; i < brojZahjteva; i++)
                {
                    Thread.Sleep(500);

                    StudentiKonsultacijeIB140261 noviZapis = new StudentiKonsultacijeIB140261();
                    noviZapis.Studenti = student;
                    noviZapis.Predmeti = predmet;
                    noviZapis.VrijemeOdrzavanja = vrijeme;
                    noviZapis.Napomena = $"Konsultacije vezane za posljednji ispit iz predmeta {noviZapis.Predmeti.Naziv} na datum {noviZapis.VrijemeOdrzavanja} ";

                    _baza.StudentiKonsultacije.Add(noviZapis);
                }
                _baza.SaveChanges();
                Action action = () => UcitajInfo(brojZahjteva, student, predmet, vrijeme);
                BeginInvoke(action);
            });
            MessageBox.Show("Zapisi su dodani!");
            LoadData();
           // int brojZahjtevaForma = _baza.StudentiKonsultacije.Count();
           // this.Text = $"Broj prikazanih zapisa: {brojZahjtevaForma}";

        }

        private void UcitajInfo(int brojZahjteva, Student student, PredmetiIB140261 predmet, DateTime vrijeme)
        {
            for (int i = 0; i < brojZahjteva; i++)
            {
                txtInfo.Text += $"Za {student.ImePrezime} dodat zahjtev za konsultacijama -> {predmet} ({vrijeme}). {Environment.NewLine}";
            }
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var pitanje = MessageBox.Show(
                    "Da li želite obrisati zahtjev?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                //var listaTrenutnogStudenta = _baza.StudentiKonsultacije.Where(x => x.Studenti.Id == _source.Id).ToList();
                //bool datumJeManjiOdTreunotg = false;
                var trenutniDatum = DateTime.Now;
                var datumKonsultacijaStudenta = dgvPretraga.CurrentRow.DataBoundItem as StudentiKonsultacijeIB140261;
               // for (int i = 0; i < listaTrenutnogStudenta.Count; i++)
                //{
                //    if (listaTrenutnogStudenta[i].VrijemeOdrzavanja < DateTime.Now)
                //    {
                //        datumJeManjiOdTreunotg = true;
                //        break;
                //    }
                //}

                if (pitanje == DialogResult.OK && /*datumJeManjiOdTreunotg == false*/ datumKonsultacijaStudenta.VrijemeOdrzavanja>=trenutniDatum)
                {
                    var brisi = dgvPretraga.CurrentRow.DataBoundItem as StudentiKonsultacijeIB140261;
                    _baza.StudentiKonsultacije.Remove(brisi);
                    _baza.SaveChanges();
                    MessageBox.Show("Zapis obrisan!");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Nemoguće obrisati već realizovanu konsultaciju!");
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source=dgvPretraga.DataSource as List<StudentiKonsultacijeIB140261>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(source);
            forma.Show();
        }
    }
}
