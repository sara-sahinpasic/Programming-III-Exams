using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P8;
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

namespace cSharpIntroWinForms.IB140261.Reporti
{
    public partial class frmIzvjestajIB140261 : Form
    {
        //private List<KorisniciPolozeniPredmeti> _x;
        private List<KorisniciPredmeti> _x;

        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        //public frmIzvjestajIB140261(List<KorisniciPolozeniPredmeti> x)
        //{
        //    this.x = x;
        //}

        public frmIzvjestajIB140261(List<KorisniciPredmeti> x) : this()
        {
            this._x = x;
            this._x = x;
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            var tblPredmeti = new dsDLWMS.PredmetiDataTable();
            for (int i = 0; i < _x.Count; i++)
            {
                var red = tblPredmeti.NewPredmetiRow();
                red.Korisnik = _x[i].Korisnik.ToString();
                red.Predmeti = _x[i].Predmet.ToString();
                red.Godina = _x[i].GodineStudija.ToString();

                tblPredmeti.Rows.Add(red);
            }

            var rds = new ReportDataSource();
            rds.Name = "dsPredmeti";
            rds.Value = tblPredmeti;
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
