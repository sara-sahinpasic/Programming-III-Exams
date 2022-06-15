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
    public partial class frmGodineStudija : Form
    {
        KonekcijaNaBazu _baza = DLWMS.DB;
        public frmGodineStudija()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmGodineStudija_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData(List<GodineStudija> godineStudija = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = godineStudija ?? _baza.GodineStudija.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var nazivUnos = txtNaziv.Text.Trim().ToLower();
            var aktivna = cbAktivan.Checked;

            if (!ValidirajUnos())
            {
                LoadData();
                return;
            }

            GodineStudija noviZapis = new GodineStudija();
            noviZapis.Naziv = txtNaziv.Text;
            noviZapis.Aktivan = aktivna;

            var brojPostojecihElemenata = _baza.GodineStudija.Where(x => x.Naziv.ToLower().Trim() == nazivUnos).ToList().Count();

            if (brojPostojecihElemenata <= 0)
            {
                _baza.GodineStudija.Add(noviZapis);
                _baza.SaveChanges();
                MessageBox.Show("Nova godina studija dodana");
                LoadData();
            }
            else
                MessageBox.Show("Godina već postoji!");
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtNaziv, err, "Obavezna vrijedost");
        }

        
    }
}
