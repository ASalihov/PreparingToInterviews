using System.Data.Entity;
using EFLEARN.RockBandsDomain.Classes;

namespace EFLEARN.RockBandsDomain.DataModel
{
    public class ConsoleContext : DbContext
    {
        public ConsoleContext()
            : base("FuckOffDB")
        {

        }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Musician> Mucisians { get; set; }
        public DbSet<Specialization> Specializations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Band>().
            //    Property(p => p.CreatedOn).
            //    HasColumnType("datetime2");

            //modelBuilder.Entity<Band>().
            //    Property(p => p.ModifiedOn).
            //    HasColumnType("datetime2");

            modelBuilder.Entity<Band>().Ignore(p => p.IsDirty);
            base.OnModelCreating(modelBuilder);
        }
    }
}
