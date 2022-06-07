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
        private List<StudentiPredmeti> _x;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<StudentiPredmeti> x) :this()
        {
            this._x = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _x.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();

                red.Rb = $"{i+1}";
                red.ImePrezime = _x[i].Student.ImePrezime;
                red.Predmet = _x[i].Predmet.Naziv;
                red.Datum = _x[i].DatumPolaganja.ToString();
                red.Ocjena = _x[i].Ocjena.ToString();

                tblIzvjestaj.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblIzvjestaj;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
