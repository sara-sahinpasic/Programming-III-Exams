using cSharpIntroWinForms.P10;
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

namespace cSharpIntroWinForms.IB140261.ReportiIB140261
{
    public partial class frmIzvjestajIB140261 : Form
    {
        //private List<KorisniciPredmeti> _izvjestajKorisnik;
        //private List<Korisnik> izvjestajKorisnik1;

        private List<Korisnik> _izvjestajKorisnik;


        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(List<Korisnik> izvjestajKorisnik) : this()
        {
            this._izvjestajKorisnik = izvjestajKorisnik;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            //var rpc = new ReportParameterCollection();
            // rpc.Add(new ReportParameter("Ime",));
            //rpc.Add(new ReportParameter("Prezime",));

            var tblPredmeti = new dsDLWMS.PredmetiDataTable();

            for (int i = 0; i < 4; i++)
            {

                var red = tblPredmeti.NewPredmetiRow();


                //red. = _izvjestajKorisnik[i].Korisnik.ToString();
                red.Predmet = " _izvjestajKorisnik[i].Predmet.ToString()";
                red.Datum = " _izvjestajKorisnik[i].Datum.ToString()";
                red.Ocjena = "_izvjestajKorisnik[i].Ocjena.ToString()";
                red.ImePrezime = "sara";

                tblPredmeti.AddPredmetiRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPredmeti";
            rds.Value = tblPredmeti;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            //this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
