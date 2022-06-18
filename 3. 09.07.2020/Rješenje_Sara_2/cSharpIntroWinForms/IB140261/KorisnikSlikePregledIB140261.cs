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
    public partial class KorisnikSlikePregledIB140261 : Form
    {
        private Korisnik _korisnikSlika;
        KonekcijaNaBazu _baza = DLWMS.DB;

        List<KorisniciSlikeIB140261> korisniciSlike = new List<KorisniciSlikeIB140261>();
        int index = 0;
        public KorisnikSlikePregledIB140261()
        {
            InitializeComponent();
        }

        public KorisnikSlikePregledIB140261(Korisnik x) : this()
        {
            this._korisnikSlika = x;
        }
        private void KorisnikSlikePregledIB140261_Load(object sender, EventArgs e)
        {
            korisniciSlike = _baza.KorisniciSlikeIB140261.Where(x => x.Korisnik.Id == _korisnikSlika.Id).ToList();
            UcitajSlike();
        }

        private void UcitajSlike()
        {
            if (korisniciSlike.Count == 0)
            {
                MessageBox.Show("Korisnik još ne posjeduje niti jednu sliku u bazi!");
                return;
            }

            pbSlika.Image = ImageHelper.FromByteToImage(korisniciSlike[index].Slika);
        }
        private void pbSlika_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);

            DodajSlikuUBazu();
        }

        private void DodajSlikuUBazu()
        {
            var slika = pbSlika.Image;
            KorisniciSlikeIB140261 noviZapis = new KorisniciSlikeIB140261();
            noviZapis.Korisnik = _korisnikSlika;
            noviZapis.Slika = ImageHelper.FromImageToByte(slika);

            _baza.KorisniciSlikeIB140261.Add(noviZapis);
            _baza.SaveChanges();
            MessageBox.Show("Slika je pohranjena u bazu!");

            korisniciSlike.Add(noviZapis);
            UcitajSlike();
        }

        private void btnNaprijed_Click(object sender, EventArgs e)
        {
            if (korisniciSlike.Count == 0)
            {
                MessageBox.Show("Korisnik još ne posjeduje niti jednu sliku u bazi!");
                return;
            }

            index++;
            if (index >= korisniciSlike.Count)
                index = 0;
            UcitajSlike();
        }
        private void btnNazad_Click(object sender, EventArgs e)
        {
            if (korisniciSlike.Count == 0)
            {
                MessageBox.Show("Korisnik još ne posjeduje niti jednu sliku u bazi!");
                return;
            }
            index--;
            if (index < 0)
                index = korisniciSlike.Count() - 1;
            UcitajSlike();
        }
    }
}
