using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
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
        Student _student;
        public frmPretragaIB140261()
        {
            InitializeComponent();
            dgvListaPredmeta.AutoGenerateColumns = false;
         }

        public frmPretragaIB140261(Student student)
        {
            _student = student;
        }

        private void UcitajPodatke()
        {
            dgvListaPredmeta.DataSource = null;
            dgvListaPredmeta.DataSource = _baza.StudentiPredmeti.ToList();
        }

        private void txtImeIliPrezime_TextChanged(object sender, EventArgs e)
        {
            string filter = txtImeIliPrezime.Text.ToLower().Trim();
            var pretraga = _baza.StudentiPredmeti.Where(x => x.Student.Ime.ToLower().Trim().Contains(filter) || x.Student.Prezime.ToLower().Trim().Contains(filter)).ToList();

            //ToDo: dgv:: PolozeniPredmeti
            //ToDo: dgv:: Prosjek

            //ToDo: lblProsjekOcjena.Text = suma;
            //ToDo: lblKoJeOstvarioNjaveciProsjek.Text = _student.ImePrezime;

            dgvListaPredmeta.DataSource = null;
            dgvListaPredmeta.DataSource = pretraga;
        }

        private void dgvListaPredmeta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmScanIspitaIB140261 frmScanIspitaBrojIndeksa =
                    new frmScanIspitaIB140261(dgvListaPredmeta.CurrentRow.DataBoundItem as Student);
                frmScanIspitaBrojIndeksa.Show();
            }
        }

        private void frmPretragaIB140261_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }
    }
}
