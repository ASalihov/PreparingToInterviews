using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public partial class Partial
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public partial class Partial
    {
        public Partial()
        {
            this.a = 1;
            this.b = 2;
            this.c = 3;
        }
        public int c { get; set; }
    }
    public partial class PartialMethods_Base
    {
        partial void math(string str);
    }
    public partial class PartialMethods_Base
    {
        partial void math(string str)
        {
            throw new NotImplementedException();
        }
    }


}
