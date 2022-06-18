using cSharpIntroWinForms.IB140261.Report;
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
    public partial class frmIzvjestajIB140261 : Form
    {
        private List<Korisnik> _izvjestaj;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<Korisnik> x) : this()
        {
            this._izvjestaj = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            for (int i = 0; i < _izvjestaj.Count; i++)
            {
                string sviPredmeti = "";
                string sviDatumi = "";
                string sveOcjene = "";

                var red = tblIzvjestaj.NewIzvjestajRow();
                red.ImePrezime = $"{_izvjestaj[i].Ime} {_izvjestaj[i].Prezime}";
                for (int j = 0; j < _izvjestaj[i].Uspjeh.Count; j++)
                {
                    sviPredmeti += $"{_izvjestaj[i].Uspjeh[j].Predmet.Naziv}{Environment.NewLine}";
                    red.Predmet = sviPredmeti;

                    sviDatumi += $"{_izvjestaj[i].Uspjeh[j].Datum}{Environment.NewLine}";
                    red.Datum = sviDatumi;

                    sveOcjene+= $"{_izvjestaj[i].Uspjeh[j].Ocjena}{Environment.NewLine}";
                    red.Ocjena = sveOcjene;
                }
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
