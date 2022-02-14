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
            ReportParameterCollection parametri = new ReportParameterCollection();
            //parametri.Add(new ReportParameter(,))

            var tblPoruke = new ds.PorukeDataTable();
            for (int i = 0; i < 5; i++)
            {
                var red = tblPoruke.NewPorukeRow();
                red.Sadrzaj = $"Sadrzaj: {i + 1}";
                red.Datum = DateTime.Now.ToString("dd.MM.yyyy");
                tblPoruke.AddPorukeRow(red);
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsPoruke";
            dataSource.Value = tblPoruke;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.LocalReport.SetParameters(parametri);
            this.reportViewer1.RefreshReport();
        }
    }
}
