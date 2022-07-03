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
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiCovidTestoviIB140261> _source;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiCovidTestoviIB140261> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            for (int i = 0; i < _source.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Student = _source[i].Studenti.Ime + " " + _source[i].Studenti.Prezime;
                red.Datum = _source[i].Datum.ToString("g");
                red.Rezultati = _source[i].Rezultat;
                if (_source[i].NalazDostavljen == true)
                    red.NalazDostavljen = "Da";
                else
                    red.NalazDostavljen = "Ne";

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
