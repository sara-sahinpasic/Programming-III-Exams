using DLWMS.WinForms.DB;
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
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<int> _godineStudija = new List<int>()
        {
            1,2,3,4
        };
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCMBGodineStudija();
        }

        private void LoadCMBGodineStudija()
        {
            cmbGodinaStudija.DataSource = null;
            cmbGodinaStudija.DataSource = _godineStudija;
        }

        private void LoadData(List<Student> studenti = null)
        {
            studenti = studenti ?? _baza.Studenti.ToList();
            dgvPretraga.DataSource = null;
            dgvPretraga.DataSource = studenti;
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
        private void Pretraga()
        {
            var filterImePrezime = txtPretraga.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filterImePrezime))
            {
                LoadData();
                return;
            }

            var filterGodinaStudija = int.Parse(cmbGodinaStudija.SelectedItem.ToString());

            List<Student> pretraga = new List<Student>();

            if (filterGodinaStudija == 1)
            {
                pretraga = _baza.Studenti.Where(x =>
             (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
             && x.GodinaStudija == filterGodinaStudija).ToList();
            }
            else if (filterGodinaStudija == 2)
            {
                pretraga = _baza.Studenti.Where(x =>
             (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
             && x.GodinaStudija == filterGodinaStudija).ToList();
            }
            else if (filterGodinaStudija == 3)
            {
                pretraga = _baza.Studenti.Where(x =>
             (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
             && x.GodinaStudija == filterGodinaStudija).ToList();
            }
            else if (filterGodinaStudija == 4)
            {
                pretraga = _baza.Studenti.Where(x =>
             (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
             && x.GodinaStudija == filterGodinaStudija).ToList();
            }

            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var source = dgvPretraga.CurrentRow.DataBoundItem as Student;
                frmKonsultacijeIB140261 frm = new frmKonsultacijeIB140261(source);
                frm.Show();
            }
        }
    }
}
