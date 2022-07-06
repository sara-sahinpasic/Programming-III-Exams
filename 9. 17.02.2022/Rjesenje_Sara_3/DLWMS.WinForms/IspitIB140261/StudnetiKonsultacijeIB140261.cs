using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB140261
{
    [Table("StudentiKonsultacije")]
    public class StudnetiKonsultacijeIB140261
    {
        public int Id { get; set; }
        public virtual Student Student { get; set; }
        public virtual PredmetiIB140261 Predmet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}
