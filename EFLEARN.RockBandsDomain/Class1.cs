using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLEARN.RockBandsDomain.Classes
{
    public class Band
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAcive { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public IEnumerable<Mucisian> Mucisians { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Mucisian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        public Band Band { get; set; }
        public int BandId { get; set; }
    }
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
