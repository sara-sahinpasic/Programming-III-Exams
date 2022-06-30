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
        private List<StudentiKonsultacijeIB140261> _source;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
            //pImePrezime
            //pBrojZahtjeva
        }

        public frmIzvjestajIB140261(List<StudentiKonsultacijeIB140261> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var rpt = new ReportParameterCollection();
            int brojZahtjeva = _source.Count;

            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _source.Count; i++)
            {
                var imePrezime = _source[i].Studenti.ImePrezime;
                rpt.Add(new ReportParameter("pImePrezime", imePrezime));
                rpt.Add(new ReportParameter("pBrojZahtjeva", brojZahtjeva.ToString()));

                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.Predmet = _source[i].Predmeti.Naziv;
                red.Vrijeme = _source[i].VrijemeOdrzavanja.ToString();
                red.Napomena = _source[i].Napomena;

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
