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
        private Student _source;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmScanIspitaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        public frmScanIspitaIB140261(Student source) : this()
        {
            this._source = source;
        }

        private void frmScanIspitaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<KorisniciIspitiScanIB140261> korisniciIspitiScan = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = korisniciIspitiScan ?? _baza.KorisniciIspitiScan.Where(x => x.Studenti.Id == _source.Id).ToList();

                lblPregledIspitaStudent.Text = $"{_source.ImePrezime}";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }
        //************************************************************************************************
        private void dgvPretraga_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Otvaranje forme noviScanIspit UZ PRIKAZ SVIH DETALJA ZAPISA BEZ MOGUĆNOSTI NJIHOVE PROMJENE*/

            var source = dgvPretraga.CurrentRow.DataBoundItem as KorisniciIspitiScanIB140261;
            frmNoviScanIspitaIB140261 frm = new frmNoviScanIspitaIB140261(source);
            frm.Show();
        }

        private void btnDodajScanIspita_Click(object sender, EventArgs e)
        {
            /*ŠTA AKO U BAZI TRENUTNO NEMA NITI JOŠ JEDAN ZAPIS (NULL)*/

            var source = dgvPretraga.CurrentRow.DataBoundItem as KorisniciIspitiScanIB140261;
            frmNoviScanIspitaIB140261 frm = new frmNoviScanIspitaIB140261(source.Studenti);
            frm.ShowDialog();
            LoadData();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var pitanje = MessageBox.Show("Želite izbrisati zapis?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    var brisi = dgvPretraga.CurrentRow.DataBoundItem as KorisniciIspitiScanIB140261;
                    _baza.KorisniciIspitiScan.Remove(brisi);
                    _baza.SaveChanges();
                    MessageBox.Show("Zapis obrisan...");
                    LoadData();
                }
                else
                    this.Close();
            }
        }
        //************************************************************************************************


        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var source = dgvPretraga.DataSource as List<KorisniciIspitiScanIB140261>;
            frmIzvjestajIB140261 frm = new frmIzvjestajIB140261(source);
            frm.Show();
        }
    }
}
