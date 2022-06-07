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
            PitanjaOdgovori();
        }

        private void PitanjaOdgovori()
        {
            label1.Text = $"Pojasnite značenje osnovnih git komandi: add, commit, push, pull i branch";
            textBox1.Text = $"" +
                $"add: Komanda s kojom se novi ili update-ovani file postavlja u staging zonu (zona u kojoj se nalaze file-ovi prije no su postavljeni na repozitori). \r\n" +
                
                $"commit: Komanda s kojom se gore pomenuti file iz staging zone premješta (pohranjuje) na repozitorij. " +
                $"Dobra praksa je u ovom dijelu napisati/naznačiti izmjene onoga što je urađeno \r\n " +
               
                $"push: Komanda s kojom šaljemo izmjene na remote lokaciju git reporzitorija. \r\n " +
               
                $"pull: Komanda s kojom se povlačimo izmjene sa remote lokacije git reporzitorija. \r\n " +
                
                $"branch: Komanda za kreiranje nove grane za razvijanje code-a unutar repozitorija.";

            label2.Text = $"Pojasnite razliku između ključnih riječi var i dynamic, te u kojim slučajevima biste ih koristili? ";
            textBox2.Text = $"var: ključna riječ, koja svoj tip podataka dobiva već tokom vremena kompajliranja," +
                $"što između ostalog znači, ukoliko se varijala ne incijalizira, ista vraća error, " +
                $"kao i, ukoliko je varijabla incijalizirana nekim brojem (tip podatka int), tip podataka ne može biti promijenjen," +
                $"što kod dynamic-a nije slučaj. \r\n" +
               
                $"dynamic: Ključna riječ koja svoj tip podatka dobiva u run time, " +
                $"te je dozvoljeno raditi sve gore navedeno što nije sa ključnom riječju var. ";

            
            label3.Text = $"Pojasniti pojam serijlizacije podataka i njihovo pohranjivanje u fajl, te kada biste ga koristili i na kojii način?";
            textBox3.Text = $"Serijalizacija podataka je proces u kojem se neki file (svog inicijalnog tipa podatka) prevodi u niz bajtova, te se kao takav i spašava (u file, bazu podataka ili neku memoriju) da bi kasnije mogao biti vraćen u svoj prvobitni oblik, svoj inicijlani tip podatka." +
                $"Njegova osnovna namjena je da spasi trenutno stanje objekta, da bi ga kasnije mogli rekreirati kada nam isti bude potreban.";
        }
    }
}
