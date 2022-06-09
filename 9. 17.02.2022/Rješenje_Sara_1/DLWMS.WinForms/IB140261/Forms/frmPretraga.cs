using DLWMS.WinForms.DB;
using DLWMS.WinForms.IB140261;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmPretraga : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<string> godineStudija = new List<string>()
        {
            " ","1","2","3","4"
        };
        public frmPretraga()
        {
            InitializeComponent();
            dgvPretraga.AutoGenerateColumns = false;
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            LoadData();
            cmbGodinatudija.DataSource = godineStudija;
        }

        private void LoadData(List<Student> student = null)
        {
            try
            {
                dgvPretraga.DataSource = null;
                dgvPretraga.DataSource = student ?? _baza.Studenti.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.InnerException?.Message}");
            }
        }

        private void txtimePrezime_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
        private void cmbGodinatudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pretraga();
            var filter = cmbGodinatudija.SelectedItem.ToString();
            if (string.IsNullOrEmpty(filter) || filter.Contains(" "))
            {
                LoadData();
                return;
            }
            var pretraga = _baza.Studenti.Where(x => x.GodinaStudija.ToString().Contains(filter)).ToList();
            LoadData(pretraga);

        }

        private void Pretraga()
        {
            var filterImePrezime = txtimePrezime.Text.ToLower().Trim();
            //var filter = cmbGodinatudija.SelectedItem.ToString();

            if (string.IsNullOrEmpty(filterImePrezime))
            {
                LoadData();
                return;
            }

            var pretraga = _baza.Studenti.Where(x => x.Ime.ToLower().Trim().Contains(filterImePrezime)
                            || x.Prezime.ToLower().Trim().Contains(filterImePrezime)
                           /* || x.GodinaStudija.ToString().Contains(filter)*/).ToList();

            LoadData(pretraga);
        }

        private void dgvPretraga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var x = dgvPretraga.CurrentRow.DataBoundItem as Student;
                frmKonsultacije forma = new frmKonsultacije(x);
                forma.ShowDialog();
            }
        }
    }
}

