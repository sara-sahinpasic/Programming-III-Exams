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
            //pPolozeni pProsjek
            double prosjek = 0;
            for (int i = 0; i < _source.Count; i++)
            {
                prosjek += _source[i].Ocjena;
            }
            prosjek /= _source.Count();

            int brojPolozenih = _source.Count();
            var rpt = new ReportParameterCollection();
            rpt.Add(new ReportParameter("pPolozeni", brojPolozenih.ToString()));
            rpt.Add(new ReportParameter("pProsjek", prosjek.ToString()));

            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _source.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.ImePrezime = _source[i].Studenti.Ime + " " + _source[i].Studenti.Prezime;
                red.Predmet = _source[i].Predmeti.Naziv;
                red.Datum = _source[i].DatumPolaganja;
                red.Ocjena = _source[i].Ocjena.ToString();

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
