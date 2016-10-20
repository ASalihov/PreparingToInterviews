using System.Data.Entity;
using EFLEARN.RockBandsDomain.Classes;

namespace EFLEARN.RockBandsDomain.DataModel
{
    public class Context : DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Musician> Mucisians { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}
