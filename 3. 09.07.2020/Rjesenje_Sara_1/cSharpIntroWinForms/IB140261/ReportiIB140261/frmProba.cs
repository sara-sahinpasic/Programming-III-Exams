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
        private List<Korisnik> _izvjestajKorisnik;

        public frmProba()
        {
            InitializeComponent();
        }

        public frmProba(List<Korisnik> izvjestajKorisnik) : this()
        {
            this._izvjestajKorisnik = izvjestajKorisnik;
        }


        private void frmProba_Load(object sender, EventArgs e)
        {
            var tblPredmeti = new dsDLWMS.PredmetiDataTable();
            for (int i = 0; i < _izvjestajKorisnik.Count; i++)
            {
                var red = tblPredmeti.NewPredmetiRow();
                red.ImePrezime = _izvjestajKorisnik[i].Ime + " " + _izvjestajKorisnik[i].Prezime;

                for (int j = 0; j < _izvjestajKorisnik[i].Uspjeh.Count; j++)
                {
                    red.Predmet = _izvjestajKorisnik[i].Uspjeh[j].Predmet.Naziv;
                    red.Datum = _izvjestajKorisnik[i].Uspjeh[j].Datum;
                    red.Ocjena = _izvjestajKorisnik[i].Uspjeh[j].Ocjena.ToString();
                }
                tblPredmeti.AddPredmetiRow(red);
            }
            var rds = new ReportDataSource();
            rds.Name = "dsPredmeti";
            rds.Value = tblPredmeti;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
