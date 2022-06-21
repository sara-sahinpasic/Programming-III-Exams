using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IspitIB140261;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DLWMS.WinForms.Forme
{
    public partial class frmStudenti : Form
    {
        KonekcijaNaBazu _baza = DLWMSdb.Baza;
        List<string> operatori = new List<string>()
        {
            "=",">",">=","<","<="
        };
        List<int> ocjene = new List<int>()
        {
            6,7,8,9,10
        };

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            UcitajOperatore();
            UcitajOcjene();
        }

        private void UcitajOcjene()
        {
            cmbOcjena.DataSource = ocjene;
        }

        private void UcitajOperatore()
        {
            cmbOperator.DataSource = operatori;
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            //if (studenti != null)
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
        }

        private void PrikaziFormu(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
            Form form = null;
            if (student != null)
            {
                if (e.ColumnIndex == 6)
                    form = new frmStudentiPredmeti(student);
                else
                    form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }

        private void dtpOD_ValueChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
        private void dtpDO_ValueChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }
        private void Pretraga()
        {
            if (!ValidirajUnos())
            {
                UcitajPodatkeOStudentima();
                return;
            }

            var datumODFilter = dtpOD.Value;
            var datumDOFilter = dtpDO.Value;
            var operatorUnosFilter = cmbOperator.SelectedItem.ToString();
            var ocjenaUnosFilter = int.Parse(cmbOcjena.SelectedItem.ToString());

            List<Student> pretragaStudenti = new List<Student>();

            var pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Datum > datumODFilter && x.Datum < datumDOFilter).ToList();

            switch (operatorUnosFilter)
            {
                case "=":
                    pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Ocjena == ocjenaUnosFilter).ToList();
                    break;
                case ">":
                    pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Ocjena > ocjenaUnosFilter).ToList();
                    break;
                case ">=":
                    pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Ocjena >= ocjenaUnosFilter).ToList();
                    break;
                case "<":
                    pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Ocjena < ocjenaUnosFilter).ToList();
                    break;
                case "<=":
                    pretragaStudentiPredmeti_VremenskiPeriod = _baza.StudentiPredmeti.Where(x => x.Ocjena <= ocjenaUnosFilter).ToList();
                    break;
            }
            var filterStudenat_Id = pretragaStudentiPredmeti_VremenskiPeriod.Select(x => x.Student.Id).ToList();
            pretragaStudenti = _baza.Studenti.Where(x => filterStudenat_Id.Contains(x.Id)).ToList();

            lblBrojStudenata.Text = $"Broj studenata: {pretragaStudenti.Count()}";

            double prosjek = 0;
            int brojac = pretragaStudenti.Count();
            for (int i = 0; i < pretragaStudenti.Count; i++)
            {
                prosjek += pretragaStudenti[i].Prosjek;
            }
            double prosjekStudenata = prosjek / brojac;
            if (prosjekStudenata is double.NaN)
                lblProsjekStudenata.Text = $"Prosječna ocjena: {0}";
            else
                lblProsjekStudenata.Text = $"Prosječna ocjena: {prosjekStudenata}";

            UcitajPodatkeOStudentima(pretragaStudenti);
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(dtpOD, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDO, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOcjena, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOperator, err, Poruke.ObaveznaVrijednost);
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            frmCovidTestIB140261 frmCovidTestIB140261 = new frmCovidTestIB140261();
            frmCovidTestIB140261.Show();
        }
        //private bool PretragaStudenata(Student s)
        //{
        //    return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
        //            || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        //}
        //private void txtPretraga_TextChanged(object sender, EventArgs e)
        //{
        //    var filter = txtPretraga.Text.ToLower();

        //    UcitajPodatkeOStudentima(_baza.Studenti
        //      .Where(s => s.Ime.ToLower().Contains(filter)
        //          || s.Prezime.ToLower().Contains(filter)).ToList());
        //}
    }
}
