using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB140261
{
    [Table("KorisniciSlike")]
    public class KorisniciSlikeIB140261
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public byte[] Slika { get; set; }
    }
}
