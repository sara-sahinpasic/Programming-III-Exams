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
    public partial class frmNovaKonsultacija : Form
    {
        private StudentiKonsultacije _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        //private Student x;

        public frmNovaKonsultacija()
        {
            InitializeComponent();
        }

        public frmNovaKonsultacija(StudentiKonsultacije x) : this()
        {
            this._x = x;
        }

        //public frmNovaKonsultacija(Student x) :this()
        //{
        //    this.x = x;
        //}

        private void frmNovaKonsultacija_Load(object sender, EventArgs e)
        {
            LoadCMB();
        }

        private void LoadCMB()
        {
            cmbPredmeti.ValueMember = "Id";
            cmbPredmeti.DisplayMember = "Naziv";
            cmbPredmeti.DataSource = _baza.Predmeti.ToList();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidirajUnos())
                {
                    var odabraniPredmet = cmbPredmeti.SelectedItem as Predmeti;
                    var datum = dtpDatum.Value;
                    var napomena = txtNapomena.Text;

                    StudentiKonsultacije noviZapis = new StudentiKonsultacije()
                    {
                        Student = _x.Student,
                        Predmet = odabraniPredmet,
                        VrijemeOdrzavanja = datum,
                        Napomena = napomena
                    };
                    _baza.StudentiKonsultacije.Add(noviZapis);
                    _baza.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private bool ValidirajUnos()
        {
            return
                 Validator.ValidirajKontrolu(cmbPredmeti, err, Poruke.ObaveznaVrijednost) &&
                 Validator.ValidirajKontrolu(dtpDatum, err, Poruke.ObaveznaVrijednost) &&
                 Validator.ValidirajKontrolu(txtNapomena, err, Poruke.ObaveznaVrijednost);
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
