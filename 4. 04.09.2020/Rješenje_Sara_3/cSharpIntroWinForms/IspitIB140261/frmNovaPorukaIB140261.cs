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

namespace cSharpIntroWinForms.IspitIB140261
{
    public partial class frmNovaPorukaIB140261 : Form
    {
        private KorisniciPorukeIB140261 _korisniciPoruke;
        private Korisnik _korisnik;
        KonekcijaNaBazu _baza = DLWMS.DB;

        public frmNovaPorukaIB140261()
        {
            InitializeComponent();
        }

        public frmNovaPorukaIB140261(KorisniciPorukeIB140261 x) : this()
        {
            this._korisniciPoruke = x;
            _korisnik = x.Korisnik;
            UcitajPostojecuPoruku();
        }

        public frmNovaPorukaIB140261(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }

        private void UcitajPostojecuPoruku()
        {
            if (_korisniciPoruke.Sadrzaj != null)
                txtSadrzaj.Text = _korisniciPoruke.Sadrzaj;
            if (_korisniciPoruke.Slika != null)
                pbSlika.Image = ImageHelper.FromByteToImage(_korisniciPoruke.Slika);

            txtSadrzaj.ReadOnly = true; //detalji poruke bez mogućnosti njihove promjene
        }

        private void frmNovaPorukaIB140261_Load(object sender, EventArgs e)
        {
            txtPrimalac.Text = $"{_korisnik.ImePrezime}";
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (_korisniciPoruke != null)
                this.Close();

            var sadrzaj = txtSadrzaj.Text;
            var slika = pbSlika.Image;

            if (ValidirajUnos())
            {
                KorisniciPorukeIB140261 noviZapis = new KorisniciPorukeIB140261();

                noviZapis.Korisnik = _korisnik;
                noviZapis.DatumVrijeme = DateTime.Now.ToString();
                noviZapis.Sadrzaj = sadrzaj;
                noviZapis.Slika = ImageHelper.FromImageToByte(slika);

                _baza.KorisniciPoruke.Add(noviZapis);
                _baza.SaveChanges();
                MessageBox.Show("Zapis je sačuvan!");
                this.Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtSadrzaj, err, Validator.porObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
