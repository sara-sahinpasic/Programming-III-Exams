using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261
{ 
    [Table("KorisniciIspitiScan")]
    public class KorisniciIspitiScanIB140261
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public Predmet Predmet { get; set; }
        public string Napomena { get; set; }
        public byte[] SkeniraniIspit { get; set; }
        public int Varanje { get; set; }
    }
}
