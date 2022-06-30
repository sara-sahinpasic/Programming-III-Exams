
using DLWMS.WinForms.IB140261;
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
        public DbSet<StudentiKonsultacijeIB140261> StudentiKonsultacije { get; set; }

        public DbSet<StudentiPredmetiIB140261> StudentiPredmeti { get; set; }

    }
}