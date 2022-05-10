using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace cSharpIntroWinForms.IB140261
{
    public partial class Izvjestaj : Form
    {
        private Korisnik _korisnik;

        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        public Izvjestaj(Korisnik korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private void Izvjestaj_Load(object sender, EventArgs e)
        {
            //var parametri = new ReportParameterCollection();
            //parametri.Add(new ReportParameter("pIme", "amor"));
            //parametri.Add(new ReportParameter("pPrezime", "osmic"));


            var ime = new ReportParameter("pIme", _korisnik.Ime);
            //ime.Name = "pIme";
            //ime.Values.Add("amor");

            var prezime = new ReportParameter("pPrezime", _korisnik.Prezime);
            //ime.Name = "pPrezime";
            //ime.Values.Add("saric");

            //---------------------------------------------------------------------
            DataSet1.OsobeDataTable tabelaOsobe = new DataSet1.OsobeDataTable();

            List<dtoOsobe> dtOsobe = new List<dtoOsobe>();
            for (int i = 0; i < _korisnik.Uspjeh.Count; i++)
            {
                var osobe = _korisnik.Uspjeh;
                var odobeDto = new dtoOsobe()
                {
                    Ime = _korisnik.Ime,
                    Prezime = _korisnik.Prezime,
                    Predmet = osobe[i].Predmet.Naziv,
                    Datum = osobe[i].Datum,
                    Ocjena = osobe[i].Ocjena.ToString()
                };
                dtOsobe.Add(odobeDto);
            }
            var predmeti = konekcijaNaBazu.Predmeti.ToList();
            for (int i = 0; i < predmeti.Count; i++)
            {
                var predmet = predmeti[i];
                if(dtOsobe.FirstOrDefault(x=> x.Predmet == predmet.Naziv) == null)
                {
                    var odobeDto = new dtoOsobe()
                    {
                        Ime = _korisnik.Ime,
                        Prezime = _korisnik.Prezime,
                        Predmet = predmet.Naziv,
                        Ocjena = "NIJE POLOZIO",
                        Datum = ""
                    };
                    dtOsobe.Add(odobeDto);
                }
            }
            for (int i = 0; i < dtOsobe.Count; i++)
            {
                var osobe =dtOsobe;
                var redOsoba = tabelaOsobe.NewOsobeRow();
                redOsoba.Ime = osobe[i].Ime;
                redOsoba.Prezime = osobe[i].Prezime;
                redOsoba.Ocjena = osobe[i].Ocjena.ToString();
                redOsoba.Datum = osobe[i].Datum.ToString();
                redOsoba.Predmet = osobe[i].Predmet;

                tabelaOsobe.AddOsobeRow(redOsoba);
            }

            ReportDataSource dataSource = new ReportDataSource();
            dataSource.Name = "dsOsobe";
            dataSource.Value = tabelaOsobe;

            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            //---------------------------------------------------------------------

            this.reportViewer1.LocalReport.SetParameters(prezime);
            this.reportViewer1.LocalReport.SetParameters(ime);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
