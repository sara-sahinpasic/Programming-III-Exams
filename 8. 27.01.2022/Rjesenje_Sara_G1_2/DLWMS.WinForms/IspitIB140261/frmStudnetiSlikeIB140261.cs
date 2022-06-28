using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
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
    public partial class frmStudnetiSlikeIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        private StudentiPredmetiIB140261 _source;

        List<StudentiSlikeIB140261> galerijaSlika_StudentiSlike = new List<StudentiSlikeIB140261>();
        int indexSlike = 0;

        public frmStudnetiSlikeIB140261()
        {
            InitializeComponent();
        }

        public frmStudnetiSlikeIB140261(StudentiPredmetiIB140261 source) : this()
        {
            this._source = source;
        }

        private void frmStudnetiSlikeIB140261_Load(object sender, EventArgs e)
        {
            galerijaSlika_StudentiSlike = _baza.StudentiSlike.Where
                (x => x.Studenti.Id == _source.Studenti.Id).ToList();
            UcitajGaleriju();
        }

        private void UcitajGaleriju()
        {
            if (galerijaSlika_StudentiSlike.Count == 0)
            {
                lblSlikaOdDo.Text = "Slika 0/0";
                return;
            }
            lblSlikaOdDo.Text = $"Slika {indexSlike + 1}/{galerijaSlika_StudentiSlike.Count}";

            pbGalerijaSlika.Image = ImageHelper.FromByteToImage(galerijaSlika_StudentiSlike[indexSlike].Slika);

            lblDatum.Text = $"{galerijaSlika_StudentiSlike[indexSlike].DatumDodavanja}";
            lblOpisGalerija.Text = $"{galerijaSlika_StudentiSlike[indexSlike].Opis}";
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var slika = pbSlika.Image;
            var opis = txtOpis.Text;

            StudentiSlikeIB140261 noviZapis = new StudentiSlikeIB140261();
            noviZapis.Studenti = _source.Studenti;
            noviZapis.Slika = ImageHelper.FromImageToByte(slika);
            noviZapis.Opis = opis;
            noviZapis.DatumDodavanja = DateTime.Now;

            _baza.StudentiSlike.Add(noviZapis);
            _baza.SaveChanges();
            MessageBox.Show("Slika je sačuvana");
            OcistiZapis();
            galerijaSlika_StudentiSlike.Add(noviZapis);
            UcitajGaleriju();
        }       

        private void btnNazad_Click(object sender, EventArgs e)
        {
            indexSlike--;
            if (indexSlike < 0)
                indexSlike = galerijaSlika_StudentiSlike.Count() - 1;
            UcitajGaleriju();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            indexSlike++;
            if (indexSlike >= galerijaSlika_StudentiSlike.Count)
                indexSlike = 0;
            UcitajGaleriju();
        }
        private void OcistiZapis()
        {
            pbSlika.Image = null;
            txtOpis.Text = "";
        }
        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var slika = Image.FromFile(openFileDialog1.FileName);
                pbSlika.Image = slika;
            }
        }
    }
}
