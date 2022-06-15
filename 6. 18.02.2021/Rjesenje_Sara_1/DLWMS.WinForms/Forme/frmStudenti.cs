using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB140261;
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

        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmNoviStudent());
            UcitajPodatkeOStudentima();
        }

        private void UcitajPodatkeOStudentima(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
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
        private bool PretragaStudenata(Student s)
        {
            //return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
            //        || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
            return false;
        }

        private void dtpOD_ValueChanged(object sender, EventArgs e)
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

            var filterUnosOD = dtpOD.Value;
            var filterUnosDO = dtpDO.Value;
            var filterOperator = cmbOperator.SelectedItem.ToString();
            var filterOcjena = int.Parse(cmbOcjena.SelectedItem.ToString());

            var studenti = _baza.Studenti.ToList();
            List<Student> pretraga = new List<Student>();

            var pretragaPoDatumu = _baza.StudentiPredmeti.Where(x => x.Datum > filterUnosOD
            && x.Datum < filterUnosDO).ToList();
            var filterPoOcjeniOperatorDatum = pretragaPoCojeniDatumOperator(pretragaPoDatumu, filterOperator, filterOcjena);

            var studentiIDs = filterPoOcjeniOperatorDatum.Select(x => x.Student.Id).ToList();
            pretraga = _baza.Studenti.Where(x => studentiIDs.Contains(x.Id)).ToList();

            lblUkupnoStudenata.Text = $"Broj studenata: {pretraga.Count.ToString()}";
            IzracunajProsjek(pretraga);

            UcitajPodatkeOStudentima(pretraga);
        }

        private void IzracunajProsjek(List<Student> pretraga)
        {
            double prosjek = 0;
            if (pretraga.Count > 0)
            {
                for (int i = 0; i < pretraga.Count; i++)
                {
                    prosjek += pretraga[i].ProsjecnaOcjena;
                }

                prosjek /= pretraga.Count;
            }



            lblProsjecnaOcjena.Text = $"Prosječna ocjena: {prosjek}";
        }

        private List<StudentiPredmeti> pretragaPoCojeniDatumOperator(List<StudentiPredmeti> pretragaPoDatumu, string filterOperator, int filterOcjena)
        {
            switch (filterOperator)
            {
                case "=":
                    pretragaPoDatumu = pretragaPoDatumu.Where(x => x.Ocjena == filterOcjena).ToList();
                    break;
                case ">":
                    pretragaPoDatumu = pretragaPoDatumu.Where(x => x.Ocjena > filterOcjena).ToList();
                    break;
                case ">=":
                    pretragaPoDatumu = pretragaPoDatumu.Where(x => x.Ocjena >= filterOcjena).ToList();
                    break;
                case "<":
                    pretragaPoDatumu = pretragaPoDatumu.Where(x => x.Ocjena < filterOcjena).ToList();
                    break;
                case "<=":
                    pretragaPoDatumu = pretragaPoDatumu.Where(x => x.Ocjena <= filterOcjena).ToList();
                    break;
            }
            return pretragaPoDatumu;
        }


        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(dtpOD, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(dtpDO, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOperator, err, Poruke.ObaveznaVrijednost) &&
                Validator.ValidirajKontrolu(cmbOcjena, err, Poruke.ObaveznaVrijednost);
        }

        private void cmbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void btnCovid_Click(object sender, EventArgs e)
        {
            frmCovidTestIB140261 frmCovidTestIB140261 = new frmCovidTestIB140261();
            frmCovidTestIB140261.Show();
        }

        private void cmbOcjena_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void lblUkupnoStudenata_Click(object sender, EventArgs e)
        {

        }
        //private void txtPretraga_TextChanged(object sender, EventArgs e)
        //{
        //    var filter = txtPretraga.Text.ToLower();

        //    UcitajPodatkeOStudentima(_baza.Studenti
        //      .Where(s => s.Ime.ToLower().Contains(filter)
        //          || s.Prezime.ToLower().Contains(filter)).ToList());
        //}
    }
}
