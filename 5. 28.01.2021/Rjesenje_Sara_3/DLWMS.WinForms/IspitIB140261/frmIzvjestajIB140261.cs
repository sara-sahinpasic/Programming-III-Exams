using DLWMS.WinForms.Entiteti;
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
        private List<Student> _source;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<Student> source) : this()
        {
            this._source = source;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();
            for (int i = 0; i < _source.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.Indeks = _source[i].Indeks;
                red.Ime = _source[i].Ime;
                red.Prezime = _source[i].Prezime;
                red.Spol = _source[i].Spol.ToString();
                red.Godina = _source[i].GodinaStudija.ToString();
                if (_source[i].Aktivan == true)
                    red.Aktivan = $"Da";
                else
                    red.Aktivan = $"Ne";

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
