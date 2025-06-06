﻿using DLWMS.WinForms.Entiteti;
using DLWMS.WinForms.IspitIB140261;
using System.Data.Entity;

namespace DLWMS.WinForms.Helpers
{
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("PutanjaDoBaze")
        {
        }
        
        public virtual DbSet<Student> Studenti { get; set; }
        public virtual DbSet<Spol> Spolovi { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<StudentiPredmeti> StudentiPredmeti { get; set; }
        public virtual DbSet<Uloga> Uloge { get; set; }
        //StudentiCovidTestovi
        public virtual DbSet<StudentiCovidTestoviIB140261> StudentiCovidTestovi { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Uloge)
                .WithMany(u => u.Studenti)
                .Map(su => 
                {
                    su.MapLeftKey("Student_Id");
                    su.MapRightKey("Uloga_Id");
                    su.ToTable("StudentiUloge");
                });
        }

    }
}
