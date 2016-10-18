using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        public IEnumerable<Band> Bands { get; set; }
    }
    public class Mucisian
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        public Band Band { get; set; }
    }
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
