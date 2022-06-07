using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{
    [Table("PredmetiSeminarski")]
    public class PredmetiSeminarksi
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public Predmeti Predmet { get; set; }
        public byte[] Slika { get; set; }
        public string Opis { get; set; }
        public DateTime DatumDodavanja { get; set; }
    }
}
