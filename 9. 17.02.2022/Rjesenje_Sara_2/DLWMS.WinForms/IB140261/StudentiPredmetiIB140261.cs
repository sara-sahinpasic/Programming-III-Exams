using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB140261
    {
        public int Id { get; set; }
        public virtual Student Studenti { get; set; }
        public virtual PredmetiIB140261 Predmeti { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}
