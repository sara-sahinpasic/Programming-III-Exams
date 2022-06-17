using cSharpIntroWinForms.IB140261.Report;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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
        KonekcijaNaBazu _baza = DLWMS.DB;
        private Korisnik _korisnik;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        public frmIzvjestajIB140261(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var predmeti = _baza.Predmeti.ToList();

            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            for (int i = 0; i < predmeti.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();

                red.ImePrezime = _korisnik.ImePrezime;
                red.Predmet = predmeti[i].Naziv;
                var pretragaPredmeta = _korisnik.Uspjeh.FirstOrDefault(x => x.Predmet.Id == predmeti[i].Id);

                if (pretragaPredmeta == null)
                {
                    red.Ocjena = "NIJE POLOŽENO";
                    red.Datum = "NIJE POLOŽENO";
                }
                else
                {
                    red.Ocjena = pretragaPredmeta.Ocjena.ToString();
                    red.Datum = pretragaPredmeta.Datum;
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
