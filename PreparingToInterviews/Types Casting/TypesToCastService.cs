using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class TypesToCastService
    {
        public TypesToCastService()
        {

        }

        private void DisplayStuff()
        {
            B b1 = new D();
            B b2 = new B();

            D d1 = new D { d = 1, j = 2, a = 4, b = 5, c = 6 };
            B b3 = new B() { a = 10, b = 20, c = 30 };
            //D d2 = (D)b3;
            //D d2 = (D)b2;
            //D d3 = (D)new B();
        }
    }
}
