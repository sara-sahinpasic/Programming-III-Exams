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

namespace cSharpIntroWinForms.IB140261
{
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            //ReportParameterCollection parametri = new ReportParameterCollection();
            ReportParameter pPoruke = new ReportParameter();
            pPoruke.Name = "pPoruke";
           // pPoruke.Values.Add(/**/);

            //---------------------------------------------------------------------
            //var tblPoruke = new ds.PorukeDataTable();
            DataSet1.PorukeDataTable tabelaPoruke= new DataSet1.PorukeDataTable();
            for (int i = 0; i < 5; i++)
            {
                var redPoruka = tabelaPoruke.NewPorukeRow();
                redPoruka.Sadrzaj = //$"Sadrzaj: {i + 1}";
             //   tabelaPoruke.AddPorukeRow(redPoruka);
            }
            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsPoruke";
            dataSource.Value = tabelaPoruke;
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            //---------------------------------------------------------------------

            this.reportViewer1.LocalReport.SetParameters(pPoruke);
            this.reportViewer1.RefreshReport();
        }
    }
}
