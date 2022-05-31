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
    public partial class frmScanIspitaIB140261 : Form
    {
        private Student _student;
        KonekcijaNaBazu baza = DLWMSdb.Baza;

        public frmScanIspitaIB140261(Student student)
        {
            InitializeComponent();
            dgvPregledIspita.AutoGenerateColumns = false;
            _student = student;
        }

        private void frmScanIspitaBrojIndeksa_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            if (_student != null)
                lblPregledIspitaStudenta.Text = _student.ImePrezime;
        }

        private void UcitajPodatke()
        {
            dgvPregledIspita.DataSource = null;
            dgvPregledIspita.DataSource = baza.KorisniciIspitiScanIB140261.ToList();
        }

        private void btnDodajScanIspita_Click(object sender, EventArgs e)
        {
            frmNoviScanIspitaIB140261 frmNoviScanIspitaIB140261 = new frmNoviScanIspitaIB140261();
            frmNoviScanIspitaIB140261.Show();
        }
    }
}
