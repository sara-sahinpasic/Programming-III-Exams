using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB140261
{
    [Table("StudentiCovidTestovi")]
    public class StudentiCovidTestoviIB140261
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public DateTime Datum { get; set; }
        public string Rezultat { get; set; }
        public bool NalazDostavljen { get; set; }
    }
}
