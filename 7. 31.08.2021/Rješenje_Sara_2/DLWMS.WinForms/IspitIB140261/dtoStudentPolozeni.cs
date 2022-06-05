using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IspitIB140261
{
    public class dtoStudentPolozeni
    {
        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
        public int BrojPolozenih { get; set; }
        public double Prosjek { get; set; }
    }
}
