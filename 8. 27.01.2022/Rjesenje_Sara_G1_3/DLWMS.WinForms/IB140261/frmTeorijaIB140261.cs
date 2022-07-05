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
    public partial class frmTeorijaIB140261 : Form
    {
        public frmTeorijaIB140261()
        {
            InitializeComponent();
        }

        private void frmTeorijaIB140261_Load(object sender, EventArgs e)
        {
            UcitajPitanjaOdgovore();
        }

        private void UcitajPitanjaOdgovore()
        {
            label1.Text = "Pojasnite znacenje osnovnih git komandi: add, commit, push, pull, branch?";
            textBox1.Text = $"" +
                $"add: postavlja novo stanje (update) fajl-a u staging fazu na git repozirotiju \r\n" +
                $"commit: 'komitamo'/izvršavamo prethodno dodane promjene iz staging faze na git repozitoij - " +
                $"dobra praksa je napisati komentar onoga što je izvšeno \r\n" +
                $"push: šaljemo izmjene na remote lokaciju git repozitorija \r\n" +
                $"pull: dohvatanje/povlačenje izmjena sa remote lokacije git reporzitorija koje su urađene \r\n" +
                $"branch: kreiranje nove radne grane repozitorija";

            label2.Text = "Pojasnite razliku između ključnih riječi var i dynamic, te u kojim slučajevima biste ih koristili?";
            textBox2.Text = $"" +
                $"Glavna razlika između ključnih riječi var i dynamic je u njihovim vremenima izvršenja/inicijlaizacije.\r\n" +
                $"var: se inicijalizuje u toku compile time vremena izvršenja." +
                $"Što znači da ukoliko varijabli ne dodijelimo odmah vrijednost (u compile time) ista će uzrokovati grešku (error) te se program neće moći kompajlirati.\r\n" +
                $"dynamic: se inciljaizuje u toku run time-a, tj. varijablu je moguće deklarisati bez da se ona inicijlizira (da joj se dodijeli vrijednost)." +
                $"Samim time u toku compile time-a varijabli je moguće mijenjati njen tip podatka (npr.int->string / string->int)";
            var sara="sara";
            //error: ->>> sara = 1;
            dynamic jasko="jasko";
            jasko = 1;
            MessageBox.Show($"Var vs Dynamic: {sara} / {jasko}");

            label3.Text = "Pojasnite pojam serilizacije podataka i njihovo pohranjivanje u fajl, te kada biste a koristili i na koji način?";
            textBox3.Text = $"Serijalizacija podataka je spašavanje fajl-a iz njegovog inicijlanog tipa podatka u niz bajtova." +
                $"To se radi radi uštede memorije, a fajl se kasnije može vratiti u svoj prvobitni oblik tipa podatka kada/ako nam je isti potreban u inicijlanom tipu podatka." +
                $"Primjer korištenja ovakvog pristupa imamo ovdje na ispitu, gdje slike, inicialnog tipa Image sašavamo kao niz bajtova, te kao takvog pohranjujemo u bazu podtaka." +
                $"Uz pomoć metode unutar klase ImageHelper unutar aplikacije pohranjenu sliku u niz bajtova prikazujemo kao sliku tipa Image unutar aplikacije.";
        }
    }
}
