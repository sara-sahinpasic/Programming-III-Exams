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
        Korisnik _korisnik;
        public frmNovaPorukaIB140261(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void frmNovaPorukaIB140261_Load(object sender, EventArgs e)
        {

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            string unos = txtSadrzaj.Text;
            Image slikaUnosa = pictureBox1.Image;

            KorisniciPoruke korisniciPoruke = new KorisniciPoruke();
            if (ValidirajUnos())
            {
                korisniciPoruke.Poruke = unos;
                korisniciPoruke.Slika = ImageHelper.FromImageToByte(slikaUnosa);
                korisniciPoruke.Korisnik = _korisnik;
                baza.KorisniciPoruke.Add(korisniciPoruke);
                baza.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtSadrzaj, err, "Obavezno polje!")
                 && Validator.ObaveznoPolje(pictureBox1, err, "Obavezno polje!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
