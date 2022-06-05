using DLWMS.WinForms.DB;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.IB140261.Class;
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
    public partial class frmStudentiSlikeIB140261 : Form
    {
        private StudentiPredmeti _x;
        KonekcijaNaBazu _baza = DLWMSdb.Baza;

        public frmStudentiSlikeIB140261()
        {
            InitializeComponent();
        }

        public frmStudentiSlikeIB140261(StudentiPredmeti x) : this()
        {
            this._x = x;
        }

        private void frmStudentiSlikeIB140261_Load(object sender, EventArgs e)
        {
        }

        private void pbSlika_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlika.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var slika = pbSlika.Image;
            var opis = txtOpis.Text;
            var datum = DateTime.Now.ToString();

            StudentiSlike noviZapis = new StudentiSlike()
            {
                Student = _x.Student,
                Opis = opis,
                Datum = datum,
                SlikaProfila = ImageHelper.FromImageToByte(slika)
            };


            _baza.StudentiSlike.Add(noviZapis);
            _baza.SaveChanges();
            MessageBox.Show("Spašena fotografija...");
        }
    }
}
