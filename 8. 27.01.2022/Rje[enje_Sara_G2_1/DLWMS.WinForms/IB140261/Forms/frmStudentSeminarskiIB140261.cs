using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.IB140261
{
    public partial class frmStudentSeminarskiIB140261 : Form
    {
        private StudentiPredmeti _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<PredmetiSeminarksi> predmetiSeminarksi = new List<PredmetiSeminarksi>();
        int index = 0;

        public frmStudentSeminarskiIB140261()
        {
            InitializeComponent();
        }
        public frmStudentSeminarskiIB140261(StudentiPredmeti x) : this()
        {
            this._x = x;
        }

        private void frmStudentSeminarskiIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            predmetiSeminarksi = _baza.PredmetiSeminarksi.Where(x => x.Student.Id == _x.Student.Id).ToList();
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            if(predmetiSeminarksi.Count==0)
            {
                lblSlikaOd.Text = $"Slika 0/0";
                return;
            }
            lblSlikaOd.Text = $"Slika {index + 1}/{predmetiSeminarksi.Count}";

            pbPregledSlika.Image = ImageHelper.FromByteToImage(predmetiSeminarksi[index].Slika);

            lblDatum.Text = $"{predmetiSeminarksi[index].DatumDodavanja}";
            txtTekst.Text = $"{predmetiSeminarksi[index].Opis}";
        }

       

        private void LoadData()
        {
            lblStudent.Text = _x.Student.Ime + " " + _x.Student.Prezime;
            lblPredmet.Text = _x.Predmet.Naziv;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                var slika = pbSlika.Image;
                var opis = txtOpis.Text;
                if (ValidirajUnos())
                {
                    PredmetiSeminarksi noviZapis = new PredmetiSeminarksi()
                    {
                        Student = _x.Student,
                        Predmet = _x.Predmet,
                        DatumDodavanja = DateTime.Now,
                        Slika = ImageHelper.FromImageToByte(slika),
                        Opis = opis
                    };
                    _baza.PredmetiSeminarksi.Add(noviZapis);
                    _baza.SaveChanges();
                    MessageBox.Show("Novi zapis pohranjen u bazu!");
                    Ocisti();
                    predmetiSeminarksi.Add(noviZapis);
                    UcitajSlike();
                }
                else
                    MessageBox.Show("Potrebno unijeti sve podatke!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void Ocisti()
        {
            txtOpis.Text = " ";
            pbSlika.Image = null;
        }

        private bool ValidirajUnos()
        {
            return DLWMS.WinForms.P5.Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost) &&
                P5.Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= predmetiSeminarksi.Count)
            {
                index = 0;
            }
            UcitajSlike();

        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = predmetiSeminarksi.Count() - 1;
            }
            UcitajSlike();
        }
    }
}
