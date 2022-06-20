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

namespace cSharpIntroWinForms.IspitIB140261
{
    public partial class frmPorukeIB140261 : Form
    {
        private KorisniciPredmeti _korisniciPredmeti;
        KonekcijaNaBazu _baza = DLWMS.DB;

        public frmPorukeIB140261()
        {
            InitializeComponent();
            dgvPoruke.AutoGenerateColumns = false;
        }

        public frmPorukeIB140261(KorisniciPredmeti x) : this()
        {
            this._korisniciPredmeti = x;
        }
        private void frmPorukeIB140261_Load(object sender, EventArgs e)
        {
            lblKorisnikKomunikaija.Text = $"{_korisniciPredmeti.Korisnik.ImePrezime}";
            LoadData();
        }

        private void LoadData(List<KorisniciPorukeIB140261> korisniciPoruke = null)
        {
            try
            {
                dgvPoruke.DataSource = null;
                dgvPoruke.DataSource = korisniciPoruke ?? _baza.KorisniciPoruke.
                    Where(x => x.Korisnik.Id == _korisniciPredmeti.Korisnik.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void dgvPoruke_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPorukeIB140261;
            frmNovaPorukaIB140261 forma = new frmNovaPorukaIB140261(x);
            forma.Show();
        }

        private void btnNovaPoruka_Click(object sender, EventArgs e)
        {
            var x = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPorukeIB140261;
            frmNovaPorukaIB140261 forma = new frmNovaPorukaIB140261(x.Korisnik);
            forma.ShowDialog();
            LoadData();
        }

        private void dgvPoruke_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var pitanje = MessageBox.Show(
                    "Da li želite izbrisati poruku?",
                    "Pitanje",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);

                if (pitanje == DialogResult.OK)
                {
                    var brisi = dgvPoruke.CurrentRow.DataBoundItem as KorisniciPorukeIB140261;
                    _baza.KorisniciPoruke.Remove(brisi);
                    _baza.SaveChanges();
                    MessageBox.Show("Zapis je izbrisan!");
                    LoadData();
                }
            }
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvPoruke.DataSource as List<KorisniciPorukeIB140261>;
            if (x?.Count > 0)
            {
                frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
                forma.Show();
            }
            else
                MessageBox.Show("Korisnik još nema zapise!");
        }
    }
}
