using DLWMS.WinForms.DB;
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

namespace DLWMS.WinForms.IB140261
{
    public partial class frmNovaKonsultacijaIB140261 : Form
    {
        private StudentiKonsultacijeIB140261 _source;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        public frmNovaKonsultacijaIB140261()
        {
            InitializeComponent();
        }

        public frmNovaKonsultacijaIB140261(StudentiKonsultacijeIB140261 source) : this()
        {
            this._source = source;
        }

        private void frmNovaKonsultacijaIB140261_Load(object sender, EventArgs e)
        {
            LoadCMB();
        }

        private void LoadCMB()
        {
            cmbPredmeti.DataSource = null;
            cmbPredmeti.DataSource = _baza.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as PredmetiIB140261;
            var vrijeme = dtpDatum.Value;
            var napomena = textBox1.Text;
            if (ValidirajUnos())
            {
                StudentiKonsultacijeIB140261 noviZapis = new StudentiKonsultacijeIB140261();
                noviZapis.Studenti = _source.Studenti;
                noviZapis.Predmeti = predmet;
                noviZapis.VrijemeOdrzavanja = vrijeme;
                noviZapis.Napomena = napomena;

                _baza.StudentiKonsultacije.Add(noviZapis);
            _baza.SaveChanges();
            this.Close();
            }
            else
                MessageBox.Show($"{Poruke.ObaveznaVrijednost}");

        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDatum, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(textBox1, err, Poruke.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
