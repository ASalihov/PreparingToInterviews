using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLEARN.RockBandsDomain.Classes
{
    public class Band : IModificationHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAcive { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public IEnumerable<Musician> Mucisians { get; set; }

        public DateTime CreatedOn
        {
        }

        public DateTime ModifiedOn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool IsDirty
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
