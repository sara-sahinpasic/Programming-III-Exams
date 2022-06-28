
using DLWMS.WinForms.IspitIB140261;
using System.Data.Entity;

namespace DLWMS.WinForms.DB
{

    //DLWMSContext
    public class KonekcijaNaBazu : DbContext
    {
        public KonekcijaNaBazu() : base("DLWMSPutanja")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().ToTable("Studenti");
        }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<PredmetiIB140261> Predmeti { get; set; }
        public DbSet<StudentiPredmetiIB140261> StudentiPredmeti { get; set; }
        public DbSet<StudentiSlikeIB140261> StudentiSlike { get; set; }




    }
}