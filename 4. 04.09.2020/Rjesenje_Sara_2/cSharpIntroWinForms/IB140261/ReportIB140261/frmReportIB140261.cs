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

namespace cSharpIntroWinForms.IB140261.ReportIB140261
{
    public partial class frmReportIB140261 : Form
    {
        List<KorisniciPorukeIB140261> _printPoruka;

        public frmReportIB140261(List<KorisniciPorukeIB140261> printPoruka)
        {
            InitializeComponent();
            _printPoruka = printPoruka;
        }
        private void frmReportIB140261_Load(object sender, EventArgs e)
        {
            var tblPoruke = new dsDLWMS.PorukeDataTable();

            for (int i = 0; i < _printPoruka.Count; i++)
            {
                var red = tblPoruke.NewPorukeRow();

                red.Datum = _printPoruka[i].DatumVrijemeSlanja.ToString();
                red.Sadrzaj = _printPoruka[i].Poruke.ToString();
                red.Primalac = _printPoruka[i].Korisnik.ToString();

                tblPoruke.Rows.Add(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "noviPoruke";
            rds.Value = tblPoruke;

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }


    }
}
