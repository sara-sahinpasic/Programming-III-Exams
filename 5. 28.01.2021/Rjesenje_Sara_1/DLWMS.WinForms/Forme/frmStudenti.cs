using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IspitIB140261;
using DLWMS.WinForms.IspitIB140261.Forms;
using DLWMS.WinForms.IspitIB140261.Report;
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
        List<string> godineStudija = new List<string>()
        {
           "Sve","1","2","3"
        };
        List<dynamic> aktivnosti = new List<dynamic>()
        {
            new
            {
                Vrijednost=-1,
                Opis="Svi"
            },
             new
            {
                Vrijednost=0,
                Opis="Neaktivni"
            },
              new
            {
                Vrijednost=1,
                Opis="Aktivni"
            }
        };
        public frmStudenti()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudenti_Load(object sender, EventArgs e)
        {
            UcitajPodatkeOStudentima();
            UcitajCMB();
        }

        private void UcitajCMB()
        {
            cmbGodineStudija.DataSource = godineStudija;
            cmbAktivnost.ValueMember = "Vrijednost";
            cmbAktivnost.DisplayMember = "Opis";
            cmbAktivnost.DataSource = aktivnosti;
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
                // else
                // form = new frmNoviStudent(student);
                PrikaziFormu(form);

                UcitajPodatkeOStudentima();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void IzracunajProsjek(List<Student> studenti) //izračunati prosjek
        {
            double prosjek = 0;
            for (int i = 0; i < studenti.Count; i++)
            {
                //double temp = 0;
                //for (int j = 0; j < studenti[i].PolozeniPredmeti.Count; j++)
                //{
                //    temp += studenti[i].PolozeniPredmeti[j].Ocjena;
                //}
                //if (studenti[i].PolozeniPredmeti.Count > 0)
                //    prosjek += temp / studenti[i].PolozeniPredmeti.Count;
                prosjek += studenti[i].ProsjecnaOcjena;
            }
            var prosjekSvihStudenata = prosjek / studenti.Count;
            if (prosjekSvihStudenata is double.NaN)
                lblProsjekStudenata.Text = $"Prosječna ocjena: {0}";
            else
                lblProsjekStudenata.Text = $"Prosječna ocjena: {prosjekSvihStudenata}";

        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, Poruke.ObaveznaVrijednost);
        }
        private void cmbGodineStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();

        }
        private void cmbAktivnot_SelectedIndexChanged(object sender, EventArgs e)
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
            var imePrezimeFilter = txtPretraga.Text.Trim().ToLower();
            var godinaStudijaFilter = cmbGodineStudija.SelectedItem.ToString();
            var aktivanFilter = int.Parse(cmbAktivnost.SelectedValue.ToString());

            List<Student> pretraga = new List<Student>();

            if (godinaStudijaFilter == "Sve" && aktivanFilter == -1)
            {
                pretraga = _baza.Studenti.Where(
                  s => s.Ime.ToLower().Trim().Contains(imePrezimeFilter) ||
                  s.Prezime.ToLower().Trim().Contains(imePrezimeFilter)).ToList();
            }
            else if (aktivanFilter == -1)
            {
                int godinaStudija = int.Parse(godinaStudijaFilter);
                pretraga = _baza.Studenti.Where(
                   s => (s.Ime.ToLower().Trim().Contains(imePrezimeFilter) ||
                   s.Prezime.ToLower().Trim().Contains(imePrezimeFilter)) &&
                   s.GodinaStudija == godinaStudija
                   ).ToList();
            }
            else if (godinaStudijaFilter == "Sve")
            {
                bool aktivan = aktivanFilter > 0;

                pretraga = _baza.Studenti.Where(
                     s => (s.Ime.ToLower().Trim().Contains(imePrezimeFilter) ||
                     s.Prezime.ToLower().Trim().Contains(imePrezimeFilter)) &&
                     s.Aktivan == aktivan).ToList();
            }
            else
            {
                bool aktivan = aktivanFilter > 0;
                int godinaStudija = int.Parse(godinaStudijaFilter);

                pretraga = _baza.Studenti.Where(
                     s => (s.Ime.ToLower().Trim().Contains(imePrezimeFilter) ||
                     s.Prezime.ToLower().Trim().Contains(imePrezimeFilter)) &&
                     s.GodinaStudija == godinaStudija &&
                     s.Aktivan == aktivan).ToList();
            }
            IzracunajProsjek(pretraga);
            lblBrojStudenata.Text = $"Broj studenata: {pretraga.Count.ToString()}";
            UcitajPodatkeOStudentima(pretraga);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var studenti = dgvStudenti.DataSource as List<Student>;
            //if (studenti?.Count > 0)
            //{
            //    frmReportIB140261 frmReportIB140261 = new frmReportIB140261(studenti);
            //    frmReportIB140261.ShowDialog();
            //}

            hshshs hshshs = new hshshs(studenti);
            hshshs.ShowDialog();
        }

        private void btnGenerisiPotvrde_Click(object sender, EventArgs e)
        {
            frmPotvrdeIB140261 frmPotvrdeIB140261 = new frmPotvrdeIB140261();
            frmPotvrdeIB140261.ShowDialog();
        }


        //private bool PretragaStudenata(Student s) - viška funkcija by denis
        //{
        //    return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
        //            || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        //}

        //private void btnNoviStudent_Click(object sender, EventArgs e) - viška funkcija by denis
        //{
        //    PrikaziFormu(new frmNoviStudent());
        //    UcitajPodatkeOStudentima();
        //}
    }
}
