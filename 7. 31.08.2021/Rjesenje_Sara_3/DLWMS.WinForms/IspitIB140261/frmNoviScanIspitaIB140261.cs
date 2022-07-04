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
        private KorisniciIspitiScanIB140261 _sourceKorisniciIspitiScan;
        private Student _studenti;

        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmNoviScanIspitaIB140261()
        {
            InitializeComponent();
        }
        // za kreiranje ispita
        public frmNoviScanIspitaIB140261(Student studenti) : this()
        {
            this._studenti = studenti;
            UcitaJPredmete();
        }
        // za pregledanje ispita
        public frmNoviScanIspitaIB140261(KorisniciIspitiScanIB140261 source) : this()
        {
            this._sourceKorisniciIspitiScan = source;
            PregledIspita(source);
        }

        private void PregledIspita(KorisniciIspitiScanIB140261 source)
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.Items.Add(source.Predmeti);
            cmbPredmeti.SelectedIndex = 0;

            txtNapomena.Text = source.Napomena;
            cbVaranje.Checked = source.Varanje;

            if (source.Ispit != null)
                pbSlika.Image = ImageHelper.FromByteToImage(source.Ispit);

            cmbPredmeti.Enabled = false;
            txtNapomena.ReadOnly = true;
            cbVaranje.Enabled = false;
            pbSlika.Enabled = false;
        }
      
        private void UcitaJPredmete()
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.DataSource = _baza.Predmet.ToList();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as Predmet;
            var napomena = txtNapomena.Text;
            var slika = pbSlika.Image;
            var varanje = cbVaranje.Checked;
            if (ValidirajUnos())
            {
                KorisniciIspitiScanIB140261 noviZapis = new KorisniciIspitiScanIB140261();
                //noviZapis.Studenti = _source.Studenti;
                noviZapis.Studenti = _studenti;
                noviZapis.Predmeti = predmet;
                noviZapis.Napomena = napomena;
                noviZapis.Ispit = ImageHelper.FromImageToByte(slika);
                noviZapis.Varanje = varanje;

                _baza.KorisniciIspitiScan.Add(noviZapis);

                _baza.SaveChanges();
                MessageBox.Show("Zapis sačuvan...");
                this.Close();
            }
            else
                MessageBox.Show("Potrebno unijeti sva tražena polja...");

        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(pbSlika, err, Poruke.ObaveznaVrijednost);
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var slikaPutanja = Image.FromFile(openFileDialog1.FileName);
                pbSlika.Image = slikaPutanja;
            }
        }
    }
}
