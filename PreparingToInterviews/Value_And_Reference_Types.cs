using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class Value_And_Reference_Types
    {
        public void TestValRefTypes()
        {
            Human man = new Human();
            man.Name = "Aleksey";
            Human var1 = man;
            var1.Name = "Viktor";
            Console.WriteLine(man.Name);
        }
    }
}
