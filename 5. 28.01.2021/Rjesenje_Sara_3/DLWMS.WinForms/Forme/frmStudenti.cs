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
        List<string> godineStudija = new List<string>()
        {
            "Sve","1","2","3"
        };
        List<dynamic> aktivnosti = new List<dynamic>()
        {
            new
            {
                Vrijednost=-1,
                Naziv="Svi"
            },
            new
            {
                Vrijednost=1,
                Naziv="Aktivni"
            },
            new
            {
                Vrijednost=0,
                Naziv="Neaktivni"
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
            UcitajGodineStudija_CMB();
            UcitajAktivnost_CMB();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            //PrikaziFormu(new frmNoviStudent());
            //UcitajPodatkeOStudentima();
            var source = dgvStudenti.DataSource as List<Student>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(source);
            forma.Show();
        }

        private void UcitajAktivnost_CMB()
        {
            cmbAktivnost.ValueMember = "Vrijednost";
            cmbAktivnost.DisplayMember = "Naziv";
            cmbAktivnost.DataSource = aktivnosti;
        }

        private void UcitajGodineStudija_CMB()
        {
            cmbGodinaStudija.DataSource = null;
            cmbGodinaStudija.DataSource = godineStudija;
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
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            //var filter = txtPretraga.Text.ToLower();

            //UcitajPodatkeOStudentima(_baza.Studenti
            //  .Where(s => s.Ime.ToLower().Contains(filter)
            //      || s.Prezime.ToLower().Contains(filter)).ToList());
            Pretraga();
        }
        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
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
            var filterImePrezime = txtPretraga.Text.Trim().ToLower();
            var filterGodinaStudija = cmbGodinaStudija.SelectedItem.ToString();
            var filterAktivnost = int.Parse(cmbAktivnost.SelectedValue.ToString());


            List<Student> pretraga = new List<Student>();

            if (filterGodinaStudija == "Sve" && filterAktivnost == -1)
            {
                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))).ToList();
            }
            else if (filterGodinaStudija == "Sve")
            {
                bool aktivan = filterAktivnost > 0;
                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
                  && (x.Aktivan == aktivan)).ToList();
            }
            else if (filterAktivnost == -1)
            {
                int godinaStudija = int.Parse(filterGodinaStudija);
                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.Trim().ToLower().Contains(filterImePrezime) | x.Prezime.Trim().ToLower().Contains(filterImePrezime))
                  && (x.GodinaStudija == godinaStudija)).ToList();
            }
            else
            {
                bool aktivan = filterAktivnost > 0;
                int godinaStudija = int.Parse(filterGodinaStudija);

                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.Trim().ToLower().Contains(filterImePrezime) || x.Prezime.Trim().ToLower().Contains(filterImePrezime))
                  && (x.Aktivan == aktivan)
                  && (x.GodinaStudija == godinaStudija)).ToList();
            }
            int brojStudenata = pretraga.Count();
            lblBrojStudenata.Text = $"Broj studenata: {brojStudenata}";

            double prosjek = 0;
            for (int i = 0; i < pretraga.Count; i++)
            {
                prosjek += pretraga[i].ProsjecnaOcjena;
            }
            prosjek /= pretraga.Count;
            lblProsjecnaOcjena.Text = $"Prosječna ocjena: {prosjek}";
            UcitajPodatkeOStudentima(pretraga);
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, Poruke.ObaveznaVrijednost);
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            frmPotvrdeIB140261 forma = new frmPotvrdeIB140261();
            forma.Show();
        }
    }
}
