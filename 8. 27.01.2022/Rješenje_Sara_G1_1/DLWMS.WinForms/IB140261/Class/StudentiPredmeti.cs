using DLWMS.WinForms.IB140261.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmeti
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual Predmeti Predmeti { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}
