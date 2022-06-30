using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{
    [Table("StudentiKonsultacije")]
    public class StudentiKonsultacijeIB140261
    {
        public int Id { get; set; }
        public Student Studenti { get; set; }
        public PredmetiIB140261 Predmeti { get; set; }
        public DateTime VrijemeOdrzavanja { get; set; }
        public string Napomena { get; set; }
    }
}
