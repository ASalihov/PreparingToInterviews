using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    internal class B
    {
        public int a;
        public int b;
        public int c;

        public override string ToString()
        {
            return "it is B!";
        }
    }
    internal class D : B
    {
        public int d;
        public int j;

        public override string ToString()
        {
            return "it is D!";
        }
    }
}
