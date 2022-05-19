using cSharpIntroWinForms.P8;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpIntroWinForms.IB140261.Reporti
{
    public partial class frmIzvjestajIB140261 : Form
    {
        public frmIzvjestajIB140261()
        {
            InitializeComponent();
        }

        private void frmIzvjestajIB140261_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
