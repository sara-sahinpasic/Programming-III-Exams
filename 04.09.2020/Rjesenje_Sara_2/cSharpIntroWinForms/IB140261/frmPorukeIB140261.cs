using cSharpIntroWinForms.IB140261.ReportIB140261;
using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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
    public partial class frmPorukeIB140261 : Form
    {
        Korisnik _korisnik;
        KonekcijaNaBazu baza = DLWMS.DB;

        public frmPorukeIB140261(Korisnik korisnik)
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;

            _korisnik = korisnik;

            UcitajDGV();
        }
        private void UcitajDGV()
        {
            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = baza.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
        }
        private void frmPorukeIB140261_Load(object sender, EventArgs e)
        {
            lblKomunikacijaSa.Text = _korisnik.Ime + " " + _korisnik.Prezime;
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            frmNovaPorukaIB140261 frmNovaPorukaIB140261 = new frmNovaPorukaIB140261(_korisnik);
            frmNovaPorukaIB140261.Show();
            UcitajDGV();
        }

        private void dgvPoruke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var pitanje = MessageBox.Show(
                    "Da li želite izbrisati poruku?",
                    "Pitanje",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (DialogResult.Yes == pitanje)
                {
                    var brisanje = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPorukeIB140261;
                    baza.KorisniciPoruke.Remove(brisanje);
                    baza.SaveChanges();
                    UcitajDGV();
                    MessageBox.Show("Poruka je izbrisana");
                }
            }
            else //prikazati detalje poruke bez mogućnosti njihove promjene
            {
                frmNovaPorukaIB140261 frmNovaPorukaIB140261 = new frmNovaPorukaIB140261(_korisnik);
                frmNovaPorukaIB140261.Show();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var printPoruka = dgvPoruke.DataSource as List<KorisniciPorukeIB140261>;
            if (printPoruka?.Count > 0) //printPoruka!=0 && printPoruka > 0 
            {
                frmReportIB140261 frmReportIB140261 = new frmReportIB140261(printPoruka);
                frmReportIB140261.Show();
            }
        }
    }
}
