using cSharpIntroWinForms.IspitIB140261.Report;
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

namespace cSharpIntroWinForms.IspitIB140261
{
    public partial class frmIzvjestajIB140261 : Form
    {
        private List<KorisniciPorukeIB140261> _izvjestaj;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<KorisniciPorukeIB140261> x) : this()
        {
            this._izvjestaj = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var rpt = new ReportParameterCollection();

            var tblPoruke = new dsDLWMS.IzvjestajDataTable();

            for (int i = 0; i < _izvjestaj.Count; i++)
            {
                rpt.Add(new ReportParameter("pIme", _izvjestaj[i].Korisnik.Ime));
                rpt.Add(new ReportParameter("pPrezime", _izvjestaj[i].Korisnik.Prezime));

                var red = tblPoruke.NewIzvjestajRow();
                red.Datum = _izvjestaj[i].DatumVrijeme;
                red.Sadrzaj = _izvjestaj[i].Sadrzaj;
                //red.Slika = _izvjestaj[i].Slika.ToString();

                tblPoruke.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblPoruke;

            this.reportViewer1.LocalReport.SetParameters(rpt);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
