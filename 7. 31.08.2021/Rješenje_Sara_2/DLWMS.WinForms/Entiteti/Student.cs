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
        // student sa ID 1
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public int GodinaStudija { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime} {Prezime}";
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual ICollection<Uloga> Uloge { get; set; }
        public virtual /*ICollection*/ List<StudentiPredmeti> StudentiPredmeti { get; set; }

        public double ProsjecnaOcjena
        {
            get
            {
                double prosjek = 0;
                if (StudentiPredmeti.Any())
                    prosjek = Math.Round(StudentiPredmeti.Average(x => x.Ocjena), 2);
                return prosjek;
            }
        }

        public string PolozeniPredmeti
        {
            get
            {
                string predmeti = "";
                if (StudentiPredmeti.Any())
                {
                    foreach (var PolozeniPredmet in StudentiPredmeti)
                    {
                        predmeti += $"{PolozeniPredmet.Predmet.Naziv}; ";
                    }
                }
                return predmeti;
            }
        }
        public int BrojPolozenih
        {
            get
            {
                return StudentiPredmeti.Count;
            }
        }




        public Student()
        {
            // PolozeniPredmeti = new List<PolozeniPredmet>();
            Uloge = new HashSet<Uloga>();
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
