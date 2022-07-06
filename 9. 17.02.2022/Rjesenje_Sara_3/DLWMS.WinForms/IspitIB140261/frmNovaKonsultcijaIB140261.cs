using DLWMS.WinForms.DB;
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
    public partial class frmNovaKonsultcijaIB140261 : Form
    {
        private Student _sourceStudnet;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;


        public frmNovaKonsultcijaIB140261()
        {
            InitializeComponent();
        }

        public frmNovaKonsultcijaIB140261(Student sourceStudnet) : this()
        {
            this._sourceStudnet = sourceStudnet;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var predmet = cmbPredmeti.SelectedItem as PredmetiIB140261;
            var student = _sourceStudnet;
            var datum = dtpDatum.Value;
            var napomena = txtNapomena.Text;

            StudnetiKonsultacijeIB140261 noviZapis = new StudnetiKonsultacijeIB140261();
            noviZapis.Student = student;
            noviZapis.Predmet = predmet;
            noviZapis.VrijemeOdrzavanja = datum;
            noviZapis.Napomena = napomena;


            _baza.StudentiKonsultacije.Add(noviZapis);
            _baza.SaveChanges();
            //LoadData();
            MessageBox.Show("Zapisi dodani...");
            this.Close();
        }

        private void frmNovaKonsultcijaIB140261_Load(object sender, EventArgs e)
        {
            LoadCmbPredmeti();
        }

        private void LoadCmbPredmeti()
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.DataSource = _baza.Predmeti.ToList();
        }
    }
}
