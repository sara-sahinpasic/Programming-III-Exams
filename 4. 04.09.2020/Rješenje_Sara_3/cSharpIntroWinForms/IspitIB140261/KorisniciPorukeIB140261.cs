using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IspitIB140261
{
    [Table("KorisniciPoruke")]
    public class KorisniciPorukeIB140261
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public string DatumVrijeme { get; set; }
        public string Sadrzaj { get; set; }
        public byte[]  Slika { get; set; }
    }
}
