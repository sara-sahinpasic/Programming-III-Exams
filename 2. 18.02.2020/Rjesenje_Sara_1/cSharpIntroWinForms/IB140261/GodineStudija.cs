﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.IB140261
{
    [Table("GodineStudija")]
    public class GodineStudija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Aktivan { get; set; }
        public override string ToString() => Naziv;
    }
}
