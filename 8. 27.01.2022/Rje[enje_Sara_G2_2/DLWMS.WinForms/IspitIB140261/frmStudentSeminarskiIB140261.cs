using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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

namespace DLWMS.WinForms.IspitIB140261
{
    public partial class frmStudentSeminarskiIB140261 : Form
    {
        private StudentiPredmetiIB140261 _source;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        List<PredmetiSeminarskiIB140261> galerijaSlika = new List<PredmetiSeminarskiIB140261>();
        int index = 0;

        public frmStudentSeminarskiIB140261()
        {
            InitializeComponent();
        }

        public frmStudentSeminarskiIB140261(StudentiPredmetiIB140261 source) : this()
        {
            this._source = source;
        }

        private void frmStudentSeminarskiIB140261_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"{_source.Studenti.Ime} {_source.Studenti.Prezime}";
            lblPredmet.Text = $"{_source.Predmeti.Naziv}";

            galerijaSlika = _baza.PredmetiSeminarski.Where(x => x.Studenti.Id == _source.Studenti.Id).ToList();
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            if (galerijaSlika.Count() == 0)
            {
                lblStranicaOdDo.Text = $"Stranica 0/0";
                return;
            }

            lblStranicaOdDo.Text = $"Stranica {index+1}/{galerijaSlika.Count()}";
            pbGalerijaSlika.Image = ImageHelper.FromByteToImage(galerijaSlika[index].Slika);
            lblDatum.Text = $"{galerijaSlika[index].DatumDodavanja}";
            lblOpisGalerija.Text = $"{galerijaSlika[index].Opis}";
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var slika = Image.FromFile(openFileDialog1.FileName);
                pbSlika.Image = slika;
            }
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var slika = pbSlika.Image;
            var opis = txtOpis.Text;

            if (ValidirajUnos())
            {
                //err.Clear();

                PredmetiSeminarskiIB140261 noviZapis = new PredmetiSeminarskiIB140261();
                noviZapis.Studenti = _source.Studenti;
                noviZapis.Predmeti = _source.Predmeti;
                noviZapis.Slika = ImageHelper.FromImageToByte(slika);
                noviZapis.Opis = opis;
                noviZapis.DatumDodavanja = DateTime.Now;
                _baza.PredmetiSeminarski.Add(noviZapis);
                _baza.SaveChanges();

                galerijaSlika.Add(noviZapis);
                UcitajSlike();

                MessageBox.Show("Podaci su pohranjeni!");
                Ocisti();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtOpis, err, Poruke.ObaveznaVrijednost);
        }

        private void Ocisti()
        {
            pbSlika.Image = null;
            txtOpis.Text = "";
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
                index = galerijaSlika.Count() - 1;
            UcitajSlike();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            index++;
            if (index >= galerijaSlika.Count())
                index = 0;
            UcitajSlike();
        }
    }
}
