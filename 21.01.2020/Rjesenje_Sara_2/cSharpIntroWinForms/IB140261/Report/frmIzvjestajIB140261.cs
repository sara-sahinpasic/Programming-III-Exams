using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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

namespace cSharpIntroWinForms.IB140261.Report
{
    public partial class frmIzvjestajIB140261 : Form
    {
        Korisnik _korisnik;
        KonekcijaNaBazu baza = DLWMS.DB;

        public frmIzvjestajIB140261(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }


        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {

            var tblOcjene = new dsDLWMS.OcjeneDataTable();
            //for (int i = 0; i < ; i++)
            //{
            //    var red =;


            //    tblPoruke.Rows().Add(red);
            //}

            var rds = new ReportDataSource();
            rds.Name = "noviOcjene";
            rds.Value = tblOcjene;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
