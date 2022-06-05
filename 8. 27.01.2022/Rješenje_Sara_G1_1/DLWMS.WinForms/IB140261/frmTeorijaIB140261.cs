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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTeorijaIB140261_Load(object sender, EventArgs e)
        {
            PitanjaOdgovori();
        }

        private void PitanjaOdgovori()
        {
            label1.Text = $"Pojasnite značenje osnovnih git komandi: add, commmit, push, pull, branch?";
            textBox1.Text = "" +
                "add - dodajemo promjene u git repozitoriju u staging fazu \r\n" +
                "commit - komitamo prethodno dodane promjene iz staging faze \r\n" +
                "push - šaljemo izmjene na remote lokaciju git repozitorija \r\n" +
                "pull povlačimo izmjene sa remote lokacije git repozitorija- \r\n" +
                "branch - koristimo za krairanje grane u repozitoriju \r\n";

            label2.Text = $"Pojasnite razliku između ključnih riječi var i dynamic, te u kojim slučajevima biste ih koristili?";
            textBox2.Text = "";

            label3.Text = "Pojasnite pojam serilizacije podataka i njihovo pohranjivanje u fajl, te kada biste ga koristili i na koji način?";
            textBox3.Text = "";
        }
    }
}
