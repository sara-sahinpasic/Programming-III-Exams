using cSharpIntroWinForms.P10;
using cSharpIntroWinForms.P9;
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
    public partial class frmGodineStudijaFormIB140261 : Form
    {
        KonekcijaNaBazu baza = DLWMS.DB;
        public frmGodineStudijaFormIB140261()
        {
            InitializeComponent();
        }

        private void frmGodineStudijaFormIB140261_Load(object sender, EventArgs e)
        {
            dgvGodineStudija.AutoGenerateColumns = false;
           // Load_DataDGV();
        }

        private void Load_DataDGV(List<GodineStudijaIB140261> godineStudija = null)
        {
            dgvGodineStudija.DataSource = null;
            dgvGodineStudija.DataSource = godineStudija ?? baza.GodineStudija.ToList();
        }
    }
}
