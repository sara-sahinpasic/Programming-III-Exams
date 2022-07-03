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
            UcitajCMB_Operatori();
            UcitajCMB_Ocjene();

        }

        private void UcitajCMB_Ocjene()
        {
            cmbOcjena.DataSource = null;
            cmbOcjena.DataSource = ocjene;
        }

        private void UcitajCMB_Operatori()
        {
            cmbOperator.DataSource = null;
            cmbOperator.DataSource = operatori;
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            //if (studenti != null)
            dgvStudenti.DataSource = studenti ?? _baza.Studenti.ToList();
        }


        private void Pretraga()
        {
            if (!ValidirajUnos())
            {
                UcitajPodatkeOStudentima();
                return;
            }
            ////18.01.2020
            ////18.01.2020<=***01/07/2022<=***25/05/2025
            ////25/05/2025
            var filterDatumOD = dtpOd.Value;
            var filterDatumDO = dtpDo.Value;
            var filterOperator = cmbOperator.SelectedItem.ToString();
            var filterOcjena = int.Parse(cmbOcjena.SelectedItem.ToString());

            List<StudentiPredmeti> pretragaStudentiPredmeti = new List<StudentiPredmeti>();

            if (filterOperator == "=")
            {
                pretragaStudentiPredmeti = _baza.StudentiPredmeti.Where(x => (x.Datum > filterDatumOD && x.Datum < filterDatumDO)
                  && x.Ocjena == filterOcjena).ToList();
            }
            else if (filterOperator == ">")
            {
                pretragaStudentiPredmeti = _baza.StudentiPredmeti.Where(x => (x.Datum > filterDatumOD && x.Datum < filterDatumDO)
                  && x.Ocjena > filterOcjena).ToList();
            }
            else if (filterOperator == ">=")
            {
                pretragaStudentiPredmeti = _baza.StudentiPredmeti.Where(x => (x.Datum > filterDatumOD && x.Datum < filterDatumDO)
                  && x.Ocjena >= filterOcjena).ToList();
            }
            else if (filterOperator == "<")
            {
                pretragaStudentiPredmeti = _baza.StudentiPredmeti.Where(x => (x.Datum > filterDatumOD && x.Datum < filterDatumDO)
                  && x.Ocjena < filterOcjena).ToList();
            }
            else if (filterOperator == "<=")
            {
                pretragaStudentiPredmeti = _baza.StudentiPredmeti.Where(x => (x.Datum > filterDatumOD && x.Datum < filterDatumDO)
                  && x.Ocjena <= filterOcjena).ToList();
            }

            var filterStudent = pretragaStudentiPredmeti.Select(x => x.Student.Id).ToList();
            List<Student> pretragaStudneti = new List<Student>();
            pretragaStudneti = _baza.Studenti.Where(x => filterStudent.Contains(x.Id)).ToList();

            lblBrojStudenata.Text = $"Broj studenata: {pretragaStudneti.Count}";
            double prosjek = 0;
            for (int i = 0; i < pretragaStudneti.Count; i++)
            {
                prosjek += pretragaStudneti[i].ProsjecnaOcjena;
            }
            prosjek /= pretragaStudneti.Count;
            lblProsjecnaOcjena.Text = $"Prosječna ocjena: {prosjek}";

            UcitajPodatkeOStudentima(pretragaStudneti);

            //var pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Datum > filterDatumOD && x.Datum < filterDatumDO).ToList();
            //switch (filterOperator)
            //{
            //    case "=":
            //        pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Ocjena == filterOcjena).ToList();
            //        break;
            //    case ">":
            //        pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Ocjena > filterOcjena).ToList();
            //        break;
            //    case ">=":
            //        pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Ocjena >= filterOcjena).ToList();
            //        break;
            //    case "<":
            //        pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Ocjena < filterOcjena).ToList();
            //        break;
            //    case "<=":
            //        pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Ocjena <= filterOcjena).ToList();
            //        break;
            //}
            //List<Student> pretraga = new List<Student>();
            //var studentId_pretragaPoDatumu = pretragaPoDatumu.Select(x => x.Student.Id);
            //pretraga = _baza.Studenti.Where(x => studentId_pretragaPoDatumu.Contains(x.Id)).ToList();
            //UcitajPodatkeOStudentima(pretraga);
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(dtpOd, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDo, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOperator, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOcjena, err, Poruke.ObaveznaVrijednost);
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void dtpDo_ValueChanged(object sender, EventArgs e)
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

        private void btnCovid_Click(object sender, EventArgs e)
        {
            frmCovidTestIB140261 frmCovidTestIB140261 = new frmCovidTestIB140261();
            frmCovidTestIB140261.Show();
        }


        //private void btnNoviStudent_Click(object sender, EventArgs e)
        //{
        //    PrikaziFormu(new frmNoviStudent());
        //    UcitajPodatkeOStudentima();
        //}
        //private void PrikaziFormu(Form form)
        //{
        //    this.Hide();
        //    form.ShowDialog();
        //    this.Show();
        //}

        //private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var student = dgvStudenti.SelectedRows[0].DataBoundItem as Student;
        //    Form form = null;
        //    if (student != null)
        //    {
        //        if (e.ColumnIndex == 6)
        //            form = new frmStudentiPredmeti(student);
        //        else
        //            form = new frmNoviStudent(student);
        //        PrikaziFormu(form);

        //        UcitajPodatkeOStudentima();
        //    }
        //}
        //private bool PretragaStudenata(Student s)
        //{
        //    //return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
        //    //        || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        //}
        //private void txtPretraga_TextChanged(object sender, EventArgs e)
        //{
        //    //var filter = txtPretraga.Text.ToLower();

        //    //UcitajPodatkeOStudentima(_baza.Studenti
        //    //  .Where(s => s.Ime.ToLower().Contains(filter)
        //    //      || s.Prezime.ToLower().Contains(filter)).ToList());
        //}
    }
}
