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
    public partial class frmScanIspitaIB140261 : Form
    {
        private StudentiPredmeti _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmScanIspitaIB140261()
        {
            InitializeComponent();
            dgvPredmet.AutoGenerateColumns = false;
        }

        public frmScanIspitaIB140261(StudentiPredmeti x) : this()
        {
            this._x = x;
        }

        private void frmScanIspitaIB140261_Load(object sender, EventArgs e)
        {
            lblStudent.Text = $"{_x.Student.Ime} {_x.Student.Prezime}";
            LoadData();
        }


        private void LoadData(List<KorisniciIspitiScanIB140261> korisniciIspiti = null)
        {
            try
            {
                dgvPredmet.DataSource = null;
                dgvPredmet.DataSource = korisniciIspiti ?? _baza.KorisniciIspiti.
                    Where(x => x.Student.Id == _x.Student.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void dgvPredmet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    var pitanje = MessageBox.Show(
                        "Da li želite izbrisati zapis?",
                        "Pitanje",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (pitanje == DialogResult.OK)
                    {
                        var izbrisan = dgvPredmet.CurrentRow.DataBoundItem as KorisniciIspitiScanIB140261;
                        _baza.KorisniciIspiti.Remove(izbrisan);
                        _baza.SaveChanges();
                        LoadData();
                        MessageBox.Show("Zapis je izbrisan!");
                    }
                }
                else
                {
                    var x = dgvPredmet.CurrentRow.DataBoundItem as KorisniciIspitiScanIB140261;
                    frmNoviScanIspitaIB140261 forma = new frmNoviScanIspitaIB140261(x);
                    forma.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnDodajScan_Click(object sender, EventArgs e)
        {
            var x = dgvPredmet.DataSource as KorisniciIspitiScanIB140261;
            frmNoviScanIspitaIB140261 forma = new frmNoviScanIspitaIB140261(x);
            forma.ShowDialog();
            LoadData();
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvPredmet.DataSource as List<KorisniciIspitiScanIB140261>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
            forma.Show();
        }
    }
}
