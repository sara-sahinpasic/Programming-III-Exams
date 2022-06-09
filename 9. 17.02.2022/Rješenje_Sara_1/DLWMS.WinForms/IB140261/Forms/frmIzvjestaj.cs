using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB140261.Report;
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

namespace DLWMS.WinForms.IB140261
{
    public partial class frmIzvjestaj : Form
    {
        private List<StudentiKonsultacije> _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmIzvjestaj()
        {
            InitializeComponent();
        }

        public frmIzvjestaj(List<StudentiKonsultacije> x) : this()
        {
            this._x = x;
        }
       
        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            var tblIzvjestaj = new dsDLWMS.IzvjestajDataTable();

            var brojZahtjeva = 0;
            for (int i = 0; i < _x.Count; i++)
            {
                var id = _x[i].Student.Id;
                brojZahtjeva = _baza.StudentiKonsultacije.Where(x => x.Student.Id == id).ToList().Count();
            }

            var rpc = new ReportParameterCollection();
            rpc.Add(new ReportParameter("pIme", _x.Select(x => x.Student.Ime).FirstOrDefault()));
            rpc.Add(new ReportParameter("pPrezime", _x.Select(x => x.Student.Prezime).FirstOrDefault()));
            rpc.Add(new ReportParameter("pBrojZahtjeva", brojZahtjeva.ToString()));

            for (int i = 0; i < _x.Count; i++)
            {
                var red = tblIzvjestaj.NewIzvjestajRow();
                red.Rb = $"{i + 1}";
                red.Predmet = _x[i].Predmet.Naziv;
                red.Vrijeme = _x[i].VrijemeOdrzavanja.ToString();
                red.Napomena = _x[i].Napomena;

                tblIzvjestaj.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsIzvjestaj";
            rds.Value = tblIzvjestaj;
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.LocalReport.SetParameters(rpc);

            this.reportViewer1.RefreshReport();
        }
    }
}
