using DLWMS.WinForms.IspitIB140261.Reports;
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
        private List<KorisniciIspitiScanIB140261> _source;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<KorisniciIspitiScanIB140261> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            //pImePrezime
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            var rpt = new ReportParameterCollection();
            for (int i = 0; i < _source.Count; i++)
            {
                rpt.Add(new ReportParameter("pImePrezime", _source[i].Studenti.ImePrezime));

                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Predmet = _source[i].Predmeti.Naziv;
                red.Napomena = _source[i].Napomena;
                if (_source[i].Varanje == true)
                    red.Varanje = "Da";
                else
                    red.Varanje = "Ne";

                tblIzvjestaj.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblIzvjestaj;

            this.reportViewer1.LocalReport.SetParameters(rpt);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
