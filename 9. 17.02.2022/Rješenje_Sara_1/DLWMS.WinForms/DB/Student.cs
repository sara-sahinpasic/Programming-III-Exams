
using DLWMS.WinForms.IB140261;
using System;
using System.Collections.Generic;

namespace DLWMS.WinForms
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public int GodinaStudija { get; set; }
        // public Image Slika { get; set; }
        public byte[] Slika { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime => $"{Ime} {Prezime}";
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }

        public virtual ICollection<StudentiPredmeti> StudentiPredmeti { get; set; }

        public double ProsjecnaOcjena
        {
            get
            {
                double prosjek = 0;
                if (StudentiPredmeti.Count == 0)
                    return prosjek = 5;
                foreach (var s in StudentiPredmeti)
                {
                    prosjek += s.Ocjena;
                }
                return prosjek /=  StudentiPredmeti.Count;
            }
        }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}