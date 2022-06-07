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

namespace DLWMS.WinForms.IspitIB140261
{
    public partial class frmNoviScanIspitaIB140261 : Form
    {
        private KorisniciIspitiScanIB140261 _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmNoviScanIspitaIB140261()
        {
            InitializeComponent();
        }

        public frmNoviScanIspitaIB140261(KorisniciIspitiScanIB140261 x) : this()
        {
            this._x = x;
        }

        private void frmNoviScanIspitaIB140261_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private bool ValidirajUnos()
        {
            return //Validator.ValidirajKontrolu(cmbPredmet, err, Poruke.ObaveznaVrijednost) &&
                  Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost) &&
                   Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }

        private void UcitajPredmete()
        {
            cmbPredmet.ValueMember = "Id";
            cmbPredmet.DisplayMember = "Naziv";
            cmbPredmet.DataSource = _baza.KorisniciIspiti.Select(x => x.Predmet.Naziv).ToList();
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image slika = Image.FromFile(openFileDialog1.FileName);
                pbSlika.Image = slika;
            }
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            try
            {
                var predmet = cmbPredmet.SelectedItem as Predmet;
                var napomena = txtNapomena.Text;
                var slika = pbSlika.Image;
                KorisniciIspitiScanIB140261 noviZapis = new KorisniciIspitiScanIB140261();

                if (ValidirajUnos())
                {
                    noviZapis.Predmet = predmet;
                    noviZapis.Napomena = napomena;
                    noviZapis.SkeniranIspit = ImageHelper.FromImageToByte(slika);

                    _baza.KorisniciIspiti.Add(noviZapis);
                    _baza.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }

        }

        private void cmbPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
