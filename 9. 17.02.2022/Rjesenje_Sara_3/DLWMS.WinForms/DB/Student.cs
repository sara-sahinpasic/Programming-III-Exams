
using DLWMS.WinForms.IspitIB140261;
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
        public string ImePrezime => Ime + " " + Prezime;
        public DateTime DatumRodjenja { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public bool Aktivan { get; set; }
        public virtual List<StudentiPredmetiIB140261> StudentiPredmeti { get; set; }
        public double ProsjecnaOcjena
        {
            get
            {
                if (StudentiPredmeti.Count == 0)
                    return 5;

                double prosjek = 0;
                for (int i = 0; i < StudentiPredmeti.Count; i++)
                {
                    prosjek += StudentiPredmeti[i].Ocjena;
                }
                prosjek /= StudentiPredmeti.Count;
                return prosjek;
            }
        }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}