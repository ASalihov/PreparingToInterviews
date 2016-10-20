using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLEARN.RockBandsDomain.Classes
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public Specialization Specialization { get; set; }
        public int SpecializationId { get; set; }
        public Band Band { get; set; }
    }
}
