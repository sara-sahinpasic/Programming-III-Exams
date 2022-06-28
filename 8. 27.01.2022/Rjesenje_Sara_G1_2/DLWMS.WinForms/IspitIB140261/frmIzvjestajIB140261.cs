using DLWMS.WinForms.IspitIB140261.Report;
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
        private List<StudentiPredmetiIB140261> _source;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<StudentiPredmetiIB140261> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var prosjek = 0;
            var suma = 0;
            for (int i = 0; i < _source.Count; i++)
            {
                suma += _source[i].Ocjena;

            }
            prosjek = suma / _source.Count;
            var rpt = new ReportParameterCollection();
            rpt.Add(new ReportParameter("pProsjecnaOcjena", prosjek.ToString()));

            var tblIzvjetsaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _source.Count; i++)
            {
                var red = tblIzvjetsaj.NewIzvjestajRow();

                red.ImePrezime = _source[i].Studenti.Ime + " " + _source[i].Studenti.Prezime;
                red.Predmet = _source[i].Predmeti.Naziv;
                red.Datum = _source[i].DatumPolaganja.ToString();
                red.Ocjena = _source[i].Ocjena.ToString();

                tblIzvjetsaj.Rows.Add(red);

            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblIzvjetsaj;

            this.reportViewer1.LocalReport.SetParameters(rpt);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
