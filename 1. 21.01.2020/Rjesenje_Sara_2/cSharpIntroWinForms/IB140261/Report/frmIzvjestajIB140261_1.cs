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

namespace cSharpIntroWinForms.IB140261.Report
{
    public partial class frmIzvjestajIB140261_1 : Form
    {
        private Korisnik _korisnik;
        private KonekcijaNaBazu baza = DLWMS.DB;
        private List<Predmeti> _predmeti = new List<Predmeti>();


        public frmIzvjestajIB140261_1()
        {
            InitializeComponent();
            _predmeti = baza.Predmeti.ToList();
        }

        public frmIzvjestajIB140261_1(Korisnik korisnik) : this()
        {
            this._korisnik = korisnik;
        }

        private void frmIzvjestajIB140261_1_Load(object sender, EventArgs e)
        {
            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("Ime", _korisnik.Ime));
            rpc.Add(new ReportParameter("Prezime", _korisnik.Prezime));

            var tblPredmeti = new dsDLWMS.PredmetiDataTable();

            for (int i = 0; i < _predmeti.Count; i++)
            {
                var red = tblPredmeti.NewPredmetiRow();
                red.Predmet = _predmeti[i].Naziv;
                var pretraga = _korisnik.Uspjeh.FirstOrDefault(x => x.Predmet.Id == _predmeti[i].Id);
                if (pretraga == null)
                {
                    red.Ocjena = "NIJE POLOŽENO";
                    red.Datum = "NIJE POLOŽENO";
                }
                else
                {
                    red.Ocjena = pretraga.Ocjena.ToString();
                    red.Datum = pretraga.Datum.ToString();
                }


                tblPredmeti.AddPredmetiRow(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsOcjene";
            rds.Value = tblPredmeti;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.LocalReport.SetParameters(rpc);
            this.reportViewer1.RefreshReport();
        }
    }
}
