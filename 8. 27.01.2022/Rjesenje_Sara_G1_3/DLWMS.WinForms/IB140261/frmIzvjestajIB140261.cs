using DLWMS.WinForms.IB140261.Reports;
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

namespace DLWMS.WinForms.IB140261
{
    public partial class frmIzvjestajIB140261 : Form
    {
        private List<StudentiPredmetiIB140261> _sourceIzvjestaj;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<StudentiPredmetiIB140261> sourceIzvjestaj) : this()
        {
            this._sourceIzvjestaj = sourceIzvjestaj;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            double prosjek = 0;
            for (int i = 0; i < _sourceIzvjestaj.Count; i++)
            {
                prosjek += _sourceIzvjestaj[i].Ocjena;
            }
            prosjek /= _sourceIzvjestaj.Count;
            rpc.Add(new ReportParameter("pProsjecnaOcjena", prosjek.ToString()));

            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _sourceIzvjestaj.Count; i++)
            {

                var red = tblIzvjestaj.NewIzvjestajRow();
                red.ImePrezime = _sourceIzvjestaj[i].Student.Ime + " " + _sourceIzvjestaj[i].Student.Prezime;
                red.Predmet = _sourceIzvjestaj[i].Predmet.Naziv;
                red.Datum = _sourceIzvjestaj[i].DatumPolaganja;
                red.Ocjena = _sourceIzvjestaj[i].Ocjena.ToString();

                tblIzvjestaj.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblIzvjestaj;

            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
