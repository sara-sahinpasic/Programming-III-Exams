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
        private List<StudnetiKonsultacijeIB140261> _source;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<StudnetiKonsultacijeIB140261> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            //pImePrezime
            //pBrojZahtjeva
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            var rpc = new ReportParameterCollection();
            var brojZahtjeva = _source.Count;
            for (int i = 0; i < _source.Count; i++)
            {
                rpc.Add(new ReportParameter("pImePrezime", _source[i].Student.ImePrezime));
                rpc.Add(new ReportParameter("pBrojZahtjeva", brojZahtjeva.ToString()));

                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.Predmet = _source[i].Predmet.Naziv;
                red.Datum = _source[i].VrijemeOdrzavanja.ToString("G");
                red.Napomena = _source[i].Napomena;

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
