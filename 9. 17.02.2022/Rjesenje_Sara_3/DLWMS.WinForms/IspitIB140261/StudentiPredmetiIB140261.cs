using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB140261
{
    [Table("StudentiPredmeti")]
    public class StudentiPredmetiIB140261
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB140261 Predmet { get; set; }
        public int Ocjena { get; set; }
        public string DatumPolaganja { get; set; }
    }
}
