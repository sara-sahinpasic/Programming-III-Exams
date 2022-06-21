using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB140261
{
    [Table("StudentiPotvrde")]
    public class StudentiPotvrdeIB140261
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public string Datum { get; set; }
        public string Svrha { get; set; }
        public bool Izdata { get; set; }
    }
}
