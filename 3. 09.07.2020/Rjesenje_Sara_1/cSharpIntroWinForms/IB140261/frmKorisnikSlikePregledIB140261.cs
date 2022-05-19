using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB140261
{
    public partial class frmKorisnikSlikePregledIB140261 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        KorisniciSlikeIB140261 _korisniciSlike = null;
        public frmKorisnikSlikePregledIB140261(KorisniciSlikeIB140261 korisniciSlike)
        {
            InitializeComponent();
            _korisniciSlike = korisniciSlike;
            //UcitajSlike();
        }


        private void frmKorisnikSlikePregledIB140261_Load(object sender, EventArgs e)
        {

        }
        private void UcitajSlike()
        {
            if (_korisniciSlike.Slika != null)
            {
                pbSlika.Image = ImageHelper.FromByteToImage(_korisniciSlike.Slika);
            }
            else
            {
                MessageBox.Show("Korisnik još uvijek nema niti jednu fotografiju.");
            }
        }

        private void pbSlika_DoubleClick(object sender, EventArgs e) //dodavanje nove slike duplim klikom na PictureBox kontorlu
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image slika = Image.FromFile(openFileDialog1.FileName);
                pbSlika.Image = slika;
            }
        }
    }
}
