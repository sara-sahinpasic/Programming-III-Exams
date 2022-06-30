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

namespace DLWMS.WinForms.IB140261
{
    public partial class frmPretragaIB140261 : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<int> _godinaStudija = new List<int>()
        {
            1,2,3,4
        };
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        //List<StudentiPredmetiIB140261> studentiPredmetiIB140261 = null
        private void LoadData(List<Student> studenti = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = studenti ?? _baza.Studenti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }



        private void Pretraga()
        {
            var filterImePrezime = txtImePrezime.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filterImePrezime))
            {
                LoadData();
                return;
            }
            var filterGodinaStudija = int.Parse(cmbGodinaStudija.SelectedItem.ToString());
            List<Student> pretraga = new List<Student>();

            //pretraga = _baza.Studenti.Where(x => x.Ime.Trim().ToLower().Contains(filterImePrezime) ||
            //  x.Prezime.Trim().ToLower().Contains(filterImePrezime) &&
            //  (x.GodinaStudija == filterGodinaStudija)).ToList();
            if (filterGodinaStudija == 0)
            {
                pretraga = _baza.Studenti.Where(x => x.Ime.Trim().ToLower().Contains(filterImePrezime) ||
                  x.Prezime.Trim().ToLower().Contains(filterImePrezime)).ToList();
            }
            else
            {
                pretraga = _baza.Studenti.Where(x => x.Ime.Trim().ToLower().Contains(filterImePrezime) ||
                  x.Prezime.Trim().ToLower().Contains(filterImePrezime) &&
                  (x.GodinaStudija == filterGodinaStudija)).ToList();
            }

            LoadData(pretraga);
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCmb();

        }

        private void LoadCmb()
        {
            cmbGodinaStudija.DataSource = null;
            cmbGodinaStudija.DataSource = _godinaStudija;
        }

        private void txtImePrezime_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var source = dgvPretraga.CurrentRow.DataBoundItem as Student;
                frmKonsultacijeIB140261 forma = new frmKonsultacijeIB140261(source);
                forma.ShowDialog();
            }
        }
    }
}
