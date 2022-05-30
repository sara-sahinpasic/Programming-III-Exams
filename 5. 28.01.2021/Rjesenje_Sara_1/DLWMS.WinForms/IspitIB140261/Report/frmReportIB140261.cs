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
    public partial class hshshs : Form
    {
        private List<Student> _studenti;

        public hshshs()
        {
            InitializeComponent();
        }

        public hshshs(List<Student> studenti) : this()
        {
            this._studenti = studenti;
        }

        private void hshshs_Load(object sender, EventArgs e)
        {
            var tblStudneti = new dsDLWMS.StudentiDataTable();

            for (int i = 0; i < _studenti.Count; i++)
            {
                var red = tblStudneti.NewStudentiRow();

                red.RB = $"{i + 1}";
                red.Indeks = _studenti[i].Indeks;
                red.Ime = _studenti[i].Ime;
                red.Prezime = _studenti[i].Prezime;
                red.Spol = _studenti[i].Spol.Naziv;
                red.Godina = _studenti[i].GodinaStudija.ToString();
                if (_studenti[i].Aktivan == true)
                    red.Aktivan = "Da";
                else
                    red.Aktivan = "Ne";

                tblStudneti.AddStudentiRow(red);
            }


            var rds = new ReportDataSource();
            rds.Name = "dsStudenti";
            rds.Value = tblStudneti;

            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
