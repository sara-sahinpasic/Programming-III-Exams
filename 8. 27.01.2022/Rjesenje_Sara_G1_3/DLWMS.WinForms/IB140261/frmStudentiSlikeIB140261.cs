using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB140261.Reports;
using DLWMS.WinForms.P5;
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
    public partial class frmStudentiSlikeIB140261 : Form
    {
        private Student _student;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        List<StudentiSlikeIB140261> _galerijaSlika = new List<StudentiSlikeIB140261>();
        int index = 0;

        public frmStudentiSlikeIB140261()
        {
            InitializeComponent();
        }

        public frmStudentiSlikeIB140261(Student student) : this()
        {
            this._student = student;
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
                //var slika = pbSlika.Image;
                var slika = Image.FromFile(openFileDialog1.FileName); ;
                pbSlika.Image = slika;
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                var slika = pbSlika.Image;
                var opis = txtOpis.Text;
                var student = _student;
                var datum = DateTime.Now;
                if (ValidirajUnos())
                {
                    StudentiSlikeIB140261 noviZapis = new StudentiSlikeIB140261();
                    noviZapis.Student = student;
                    noviZapis.Slika = ImageHelper.FromImageToByte(slika);
                    noviZapis.Opis = opis;
                    noviZapis.DatumDodavanja = datum;

                    _baza.StudentiSlike.Add(noviZapis);
                    _baza.SaveChanges();

                    _galerijaSlika.Add(noviZapis);
                    UcitajGalerijuSlika();

                    MessageBox.Show("Zapis dodan...");
                }
                else
                    MessageBox.Show("Unesite sve podatke!");
                OcistiUnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void OcistiUnos()
        {
            pbSlika.Image = null;
            txtOpis.Text = "";
        }

        private bool ValidirajUnos()
        {
            return
                 Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost) &&
                 Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost);
        }


        private void frmStudentiSlikeIB140261_Load(object sender, EventArgs e)
        {
            _galerijaSlika = _baza.StudentiSlike.Where(x => x.Student.Id == _student.Id).ToList();
            UcitajGalerijuSlika();
        }

        private void UcitajGalerijuSlika()
        {
            if (_galerijaSlika.Count() == 0)
            {
                lblSlikaOdDo.Text = $"Slika {0}/{0}";
                return;
            }

            lblSlikaOdDo.Text = $"Slika {index + 1}/{_galerijaSlika.Count()} ";
            pbGalerijaSlika.Image = ImageHelper.FromByteToImage(_galerijaSlika[index].Slika);
            lblDatum.Text = _galerijaSlika[index].DatumDodavanja.ToString("G");
            lblOpisGalerija.Text = _galerijaSlika[index].Opis;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = _galerijaSlika.Count()-1;

            UcitajGalerijuSlika();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= _galerijaSlika.Count())
                index = 0;

            UcitajGalerijuSlika();
        }
    }
}
