﻿using cSharpIntroWinForms.P9;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB140261
{
    [Table("KorisniciPoruke")]
    public class KorisniciPorukeIB140261
    {
        public int Id { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime DatumVrijemeSlanja { get; set; }
        public string Poruke { get; set; }
        public byte[] Slika { get; set; }
        public Image ISlika
        {
            get
            {
                return ImageHelper.FromByteToImage(Slika);
            }
        }
    }
}


