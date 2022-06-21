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
        List<string> godinaStudija = new List<string>()
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
            UcitajCMBGodineStudija();
            UcitajCMBAktivnosti();
        }

        private void UcitajCMBAktivnosti()
        {
            cmbAktivnost.ValueMember = "Vrijednost";
            cmbAktivnost.DisplayMember = "Opis";
            cmbAktivnost.DataSource = aktivnosti;
        }

        private void UcitajCMBGodineStudija()
        {
            cmbGodinaStudija.DataSource = godinaStudija;
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
            return s.Ime.ToLower().Contains(txtPretraga.Text.ToLower())
                    || s.Prezime.ToLower().Contains(txtPretraga.Text.ToLower());
        }

        private void txtPretraga_TextChanged_1(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbAktivnost_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pretraga();
        }

        private void cmbGodinaStudija_SelectedIndexChanged(object sender, EventArgs e)
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

            var filterImePrezime = txtPretraga.Text.ToLower().Trim();
            var filterGodinaStudija = cmbGodinaStudija.SelectedItem.ToString();
            var filterAktivnost = int.Parse(cmbAktivnost.SelectedValue.ToString());

            List<Student> pretraga = new List<Student>();

            if (filterGodinaStudija == "Sve" && filterAktivnost == -1)
            {
                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.ToLower().Trim().Contains(filterImePrezime) || x.Prezime.ToLower().Trim().Contains(filterImePrezime))).ToList();
            }
            else if (filterGodinaStudija == "Sve")
            {
                bool aktivan = filterAktivnost > 0;

                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.ToLower().Trim().Contains(filterImePrezime) || x.Prezime.ToLower().Trim().Contains(filterImePrezime)) &&
                    x.Aktivan == aktivan).ToList();
            }
            else if (filterAktivnost == -1)
            {
                int godinaStudija = int.Parse(filterGodinaStudija);

                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.ToLower().Trim().Contains(filterImePrezime) || x.Prezime.ToLower().Trim().Contains(filterImePrezime)) &&
                    x.GodinaStudija == godinaStudija).ToList();
            }
            else
            {
                bool aktivan = filterAktivnost > 0;
                int godinaStudija = int.Parse(filterGodinaStudija);

                pretraga = _baza.Studenti.Where
                    (x => (x.Ime.ToLower().Trim().Contains(filterImePrezime) || x.Prezime.ToLower().Trim().Contains(filterImePrezime)) &&
                    x.GodinaStudija == godinaStudija &&
                    x.Aktivan == aktivan).ToList();
            }

            int brojStudenata = pretraga.Count();
            lblBrojStudenata.Text = $"Broj studenata: {brojStudenata}";

            double prosjek = 0, suma = 0;
            for (int i = 0; i < pretraga.Count; i++)
            {
                suma += pretraga[i].ProsjecnaOcjena;
            }
            prosjek = suma / pretraga.Count;
            if (prosjek is double.NaN)
                lblProsjecnaOcjena.Text = $"Prosječna ocjena: {0}";
            else
                lblProsjecnaOcjena.Text = $"Prosječna ocjena: {prosjek}";

            UcitajPodatkeOStudentima(pretraga);

        }
        
        private bool ValidirajUnos()
        {
            return Validator.ValidirajKontrolu(txtPretraga, err, Poruke.ObaveznaVrijednost);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var x = dgvStudenti.DataSource as List<Student>;
            frmIzvjestajIB140261 forma = new frmIzvjestajIB140261(x);
            forma.Show();
        }

        private void btnPotvrde_Click(object sender, EventArgs e)
        {
            frmPotvrdeIB140261 forma = new frmPotvrdeIB140261();
            forma.Show();
        }
    }
}
