using cSharpIntroWinForms.IB140261.Reporti;
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

namespace cSharpIntroWinForms.P8
{
    public partial class KorisniciPolozeniPredmeti : Form
    {
        private Korisnik korisnik;
        KonekcijaNaBazu konekcijaNaBazu = DLWMS.DB;
        List<int> ocjene = new List<int>()
        {
            6,7,8,9,20
        };

        public KorisniciPolozeniPredmeti()
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;

        }
        public KorisniciPolozeniPredmeti(Korisnik korisnik) : this()
        {
            this.korisnik = korisnik;
        }
        private void KorisniciPolozeniPredmeti_Load(object sender, EventArgs e)
        {
            load_data_DGV();
            load_data_CmbPredmeti();
            //load_data_CmbGodine();
        }

        private void load_data_CmbGodine()
        {
            try
            {
                cmbGodineStudija.ValueMember = "Id";
                cmbGodineStudija.DisplayMember = "Naziv";
                cmbGodineStudija.DataSource = konekcijaNaBazu.GodineStudija.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void load_data_CmbPredmeti()
        {
            try
            {
                cmbPredmeti.ValueMember = "Id";
                cmbPredmeti.DisplayMember = "Naziv";
                cmbPredmeti.DataSource = konekcijaNaBazu.Predmeti.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }

        private void load_data_DGV(List<KorisniciPredmeti> korisniciPredmeti = null)
        {
            try
            {
                dgvPolozeniPredmeti.DataSource = null;
                dgvPolozeniPredmeti.DataSource = korisniciPredmeti ?? konekcijaNaBazu.KorisniciPredmeti.ToList();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }

        }

        private void btnPrintajUvjerenje_Click(object sender, EventArgs e)
        {
            var reportPrint = dgvPolozeniPredmeti.DataSource as List<KorisniciPolozeniPredmeti>;
            if (reportPrint?.Count > 0)
            {
                frmIzvjestajIB140261 frmIzvjestajIB140261 = new frmIzvjestajIB140261();
                frmIzvjestajIB140261.ShowDialog();
            }
        }

        private void cmbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDodajPolozeni_Click(object sender, EventArgs e)
        {
            try
            {
                var ocjena = int.Parse(txtOcjene.ToString());
                var predmet = cmbPredmeti.SelectedItem as Predmeti;
                var datum = dtpDatumPolaganja.Value.ToString("dd.MM.yyyy");
                KorisniciPredmeti noviZapis = new KorisniciPredmeti();

                noviZapis.Predmet = predmet;
                noviZapis.Ocjena = ocjena;
                noviZapis.Datum = datum;
                noviZapis.Korisnik = korisnik;

                konekcijaNaBazu.KorisniciPredmeti.Add(noviZapis);
                konekcijaNaBazu.SaveChanges();

                load_data_DGV();
                MessageBox.Show("Predmet je dodan.");
            }
            catch (Exception ex)
            {

                MboxHelper.PrikaziGresku(ex);
            }
        }
    }
}
