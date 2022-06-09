using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{
    [Table("StudentiKonsultacije")]
    public class StudentiKonsultacije
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmeti Predmet { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}
