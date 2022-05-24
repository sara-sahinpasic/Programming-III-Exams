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
    public partial class frmProba : Form
    {
        private List<Korisnik> izvjestajKorisnik;

        public frmProba()
        {
            InitializeComponent();
        }

        public frmProba(List<Korisnik> izvjestajKorisnik) : this()
        {
            this.izvjestajKorisnik = izvjestajKorisnik;
        }

        private void frmProba_Load(object sender, EventArgs e)
        {
            var tblPredmeti = new dsDLWMS.PredmetiDataTable();

            for (int i = 0; i < izvjestajKorisnik.Count; i++)
            {
                for (int j = 0; j < izvjestajKorisnik[i].Uspjeh.Count; j++)
                {
                    var red = tblPredmeti.NewPredmetiRow();
                    var polozeniPredmet = izvjestajKorisnik[i].Uspjeh[j];

                    red.Predmet = polozeniPredmet.Predmet.Naziv;
                    red.Datum = polozeniPredmet.Datum;
                    red.Ocjena = polozeniPredmet.Ocjena.ToString();
                    red.ImePrezime = polozeniPredmet.Korisnik.Ime + polozeniPredmet.Korisnik.Prezime;
                    //  red.ImePrezime = izvjestajKorisnik[i].Ime + izvjestajKorisnik[i].Prezime;

                    tblPredmeti.AddPredmetiRow(red);
                }

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
