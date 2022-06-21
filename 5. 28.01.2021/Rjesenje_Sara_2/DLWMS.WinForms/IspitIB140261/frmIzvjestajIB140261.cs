using DLWMS.WinForms.Entiteti;
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
    public partial class frmIzvjestajIB140261 : Form
    {
        private List<Student> _izvjestaj;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<Student> x) : this()
        {
            this._izvjestaj = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            for (int i = 0; i < _izvjestaj.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.Indeks = _izvjestaj[i].Indeks;
                red.Ime = _izvjestaj[i].Ime;
                red.Prezime = _izvjestaj[i].Prezime;
                red.Spol = _izvjestaj[i].Spol.Naziv;
                red.Godina = _izvjestaj[i].GodinaStudija.ToString();
                if (_izvjestaj[i].Aktivan == true)
                    red.Aktivan = "DA";
                else
                    red.Aktivan = "NE";

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
