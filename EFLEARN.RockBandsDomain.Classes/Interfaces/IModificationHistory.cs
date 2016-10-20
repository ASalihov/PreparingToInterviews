using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLEARN.RockBandsDomain.Classes
{
    public interface IModificationHistory
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        bool IsDirty { get; set; }
    }
}
