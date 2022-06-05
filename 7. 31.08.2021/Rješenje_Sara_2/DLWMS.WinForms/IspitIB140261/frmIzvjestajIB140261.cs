using DLWMS.WinForms.IspitIB140261.Reporti;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB140261 : Form
    {
        private List<KorisniciIspitiScanIB140261> _x;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<KorisniciIspitiScanIB140261> x) : this()
        {
            this._x = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblIspiti = new dsDLWMS.IspitDataTable();

            for (int i = 0; i < _x.Count; i++)
            {
                var red = tblIspiti.NewIspitRow();

                red.Predmet = _x[i].Predmet.Naziv;
                red.Napomena = _x[i].Napomena;
                red.Varanje = _x[i].Varanje.ToString();

                tblIspiti.AddIspitRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIspiti";
            rds.Value = tblIspiti;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
