using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public enum TestEnum : byte
    {
        one = 1,
        two = 2
    }

    [Flags]
    public enum DaysOfWeek
    {
        sunday = 1,
        monday = 2,
        tuesday = 4,
        wednesday = 8,
        thursday = 16,
        friday = 31,
        saturday = 64
    }
}
