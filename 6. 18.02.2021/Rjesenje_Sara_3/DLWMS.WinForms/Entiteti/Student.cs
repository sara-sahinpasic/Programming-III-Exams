using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.Entiteti
{
    [Table("Studenti")]
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        public List<PolozeniPredmet> PolozeniPredmeti { get; set; }
        public virtual ICollection<Uloga> Uloge { get; set; }

        public virtual List<StudentiPredmeti> StudentiPredmeti { get; set; }
        public double ProsjecnaOcjena { 
            get 
            {
                double prosjek = 0;

                if (StudentiPredmeti.Count == 0)
                    return 5;
                for (int i = 0; i < StudentiPredmeti.Count; i++)
                {
                    prosjek += StudentiPredmeti[i].Ocjena;
                }
                prosjek /= StudentiPredmeti.Count;
                return prosjek;
            } }

        public Student()
        {
            PolozeniPredmeti = new List<PolozeniPredmet>();
            Uloge = new HashSet<Uloga>();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
