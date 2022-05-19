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
    public partial class frmNovaPorukaIB140261 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        private KorisniciPorukeIB140261 selektovanaPoruka = null;
        Korisnik _korisnik;

        public frmNovaPorukaIB140261(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        public frmNovaPorukaIB140261(KorisniciPorukeIB140261 poruka)
        {
            InitializeComponent();
            this.selektovanaPoruka = poruka;
            _korisnik = poruka.Korisnik;
            UcitajPoruku();

        }

        private void UcitajPoruku()
        {
            txtSadrzaj.Text = selektovanaPoruka.Poruke;
            if (selektovanaPoruka.Slika != null)
                pbSlika.Image = ImageHelper.FromByteToImage(selektovanaPoruka.Slika);

            txtSadrzaj.ReadOnly = true;
        }

        private void frmNovaPorukaIB140261_Load(object sender, EventArgs e)
        {
            txtPrimalac.Text = _korisnik.Ime + " " + _korisnik.Prezime;

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (selektovanaPoruka != null)
                this.Close(); // neće se izvršiti kod ukoliko se pozove konstruktor sa Korisnik objektom

            var unos = txtSadrzaj.Text;
            var slika = pbSlika.Image;

            KorisniciPorukeIB140261 infoPoruke = new KorisniciPorukeIB140261();
            if (ValidirajUnos())
            {
                infoPoruke.Poruke = unos;
                if (slika != null)
                    infoPoruke.Slika = ImageHelper.FromImageToByte(slika);
                infoPoruke.Korisnik = _korisnik;
                infoPoruke.DatumVrijemeSlanja = DateTime.Now;

                baza.KorisniciPoruke.Add(infoPoruke);
                baza.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pbSlika_Click(object sender, EventArgs e) //prikaz upload-ovane slike (bez icon za error)
        {
            if (selektovanaPoruka != null)
                return;

            var rezultat = openFileDialog1.ShowDialog();
            if (rezultat == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtSadrzaj, err, Validator.porObaveznaVrijednost);
        }
    }
}
