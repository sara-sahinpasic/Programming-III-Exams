﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.WinForms.IB140261.Class
{
    [Table("StudentiSlike")]
    public class StudentiSlike
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public byte[] SlikaProfila { get; set; }
        public byte[] Slike { get; set; }
        public string Datum { get; set; }
        public string Opis { get; set; }

    }
}
