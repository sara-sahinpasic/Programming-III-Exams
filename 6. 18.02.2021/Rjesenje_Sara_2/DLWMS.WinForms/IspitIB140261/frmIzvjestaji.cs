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
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiCovidTestoviIB140261> x;

        public frmIzvjestaji()
        {
            InitializeComponent();
        }

        public frmIzvjestaji(List<StudentiCovidTestoviIB140261> x) :this()
        {
            this.x = x;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < x.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Student = x[i].Student.Ime + " " + x[i].Student.Prezime;
                red.Datum = x[i].Datum.ToString();
                red.Rezultat = x[i].Rezultat;
                if (x[i].NalazDostavljen == true)
                    red.NalazDostavljen = "DA";
                else
                    red.NalazDostavljen = "NE";

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
