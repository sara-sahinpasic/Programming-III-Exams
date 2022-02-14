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
            UcitajPodatike();
        }

        private void UcitajPodatike()
        {
            dgvPoruke.DataSource = null;
            dgvPoruke.DataSource = baza.KorisniciPoruke.Where(x => x.Korisnik.Id == _korisnik.Id).ToList();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            // this.Hide();
            frmNovaPorukaIB140261 frmNovaPorukaIB140261 = new frmNovaPorukaIB140261(_korisnik);
            if (frmNovaPorukaIB140261.ShowDialog() == DialogResult.OK)
            {
                UcitajPodatike();
            }

        }

        private void dgvPoruke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DialogResult odgvovor = MessageBox.Show(
                    "Da li želite izbrisati poruku?",
                    "Pitanje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (odgvovor == DialogResult.Yes)
                {
                    var brisanje = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPoruke;
                    baza.KorisniciPoruke.Remove(brisanje);
                    baza.SaveChanges();
                    UcitajPodatike();
                    MessageBox.Show("Poruka uspješno izbrisana.");
                }
            }
            else
            {
                //this.Hide();
                frmNovaPorukaIB140261 frmNovaPorukaIB140261 = new frmNovaPorukaIB140261(_korisnik);
                frmNovaPorukaIB140261.Show();
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            // this.Hide();
            frmIzvjestaj frmIzvjestaj = new frmIzvjestaj();
            frmIzvjestaj.Show();
        }

        private void frmPorukeIB140261_Load(object sender, EventArgs e)
        {
            lblKomunikacijaSa.Text = _korisnik.Ime + " " + _korisnik.Prezime;
        }
    }
}
