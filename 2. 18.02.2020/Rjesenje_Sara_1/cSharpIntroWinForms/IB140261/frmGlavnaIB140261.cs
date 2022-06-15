using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB140261
{
    public partial class frmGlavnaIB140261 : Form
    {
        public frmGlavnaIB140261()
        {
            InitializeComponent();
        }

        private void btnGodineStudija_Click(object sender, EventArgs e)
        {
            frmGodineStudija forma = new frmGodineStudija();
            forma.ShowDialog();
        }

        private void btnPolozeniPredmeti_Click(object sender, EventArgs e)
        {
            P8.KorisniciPolozeniPredmeti korisniciPolozeniPredmeti = new P8.KorisniciPolozeniPredmeti();
            korisniciPolozeniPredmeti.ShowDialog();
        }

        private async void btnIzracunajSumu_Click(object sender, EventArgs e)
        {
            double suma = 0;
            var unos = double.Parse(txtUnosBroja.Text);
            await Task.Run(() =>
            {
                suma = IzracunajSumu(unos);
            });
            MessageBox.Show($"Rezultat: {suma}");
        }

        private double IzracunajSumu(double unos)
        {
            double suma = 0;
            for (int i = 0; i < unos; i++)
            {
                suma += i;
            }
            return suma;
        }

        private void frmGlavnaIB140261_Load(object sender, EventArgs e)
        {

        }
    }
}
