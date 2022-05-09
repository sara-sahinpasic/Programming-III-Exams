using DLWMS.WinForms.Entiteti;
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

namespace DLWMS.WinForms.IB140261
{
    public partial class frmNoviScanIspitaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        Korisnik _korisnik;
        public frmNoviScanIspitaIB140261()
        {
            InitializeComponent();
        }

        public frmNoviScanIspitaIB140261(Korisnik korisnik)
        {
            _korisnik = korisnik;
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.DataSource = _baza.Predmet.ToList();
        }

        private void frmNoviScanIspitaIB140261_Load(object sender, EventArgs e)
        {
            UcitajPredmete();

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            var unosNapomene = txtNapomena.Text;
            var odabirPredmeta = cmbPredmeti.SelectedItem;
            var unosSlike = pbSlika.Image;
            KorisniciIspitiScanIB140261 kis = new KorisniciIspitiScanIB140261();
            if (ValidirajUnose())
            {
                kis.Napomena = unosNapomene;
                kis.Predmet = odabirPredmeta as Predmet;
                kis.SkeniraniIspit = ImageHelper.FromImageToByte(unosSlike);
                _baza.KorisniciIspitiScanIB140261.Add(kis);
                //_baza.SaveChanges();
                this.Close();
            }
            frmNoviScanIspitaIB140261 frmNoviScanIspitaIB140261 = new frmNoviScanIspitaIB140261();
            frmNoviScanIspitaIB140261.Hide();
        }

        private bool ValidirajUnose()
        {
            return Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
