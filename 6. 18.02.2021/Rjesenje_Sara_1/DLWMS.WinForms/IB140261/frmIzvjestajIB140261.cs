using DLWMS.WinForms.IB140261.Report;
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
        private List<StudentiCovidTestoviIB140261> _izvjestaj;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<StudentiCovidTestoviIB140261> _izvjestaj) : this()
        {
            this._izvjestaj = _izvjestaj;
        }

        private void bbb_Load(object sender, EventArgs e)
        {
            var tblTestovi = new dsDLWMS.TestoviDataTable();

            for (int i = 0; i < _izvjestaj.Count; i++)
            {
                var red = tblTestovi.NewTestoviRow();

                red.Studenti = _izvjestaj[i].Student.ToString();
                red.Rezultat = _izvjestaj[i].Rezultat;
                if (_izvjestaj[i].NalazDostavljen == true)
                    red.Nalaz = "Da";
                else
                    red.Nalaz = "Ne";
                red.Datum = _izvjestaj[i].Datum.ToString();

                tblTestovi.AddTestoviRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsTestovi";
            rds.Value = tblTestovi;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
