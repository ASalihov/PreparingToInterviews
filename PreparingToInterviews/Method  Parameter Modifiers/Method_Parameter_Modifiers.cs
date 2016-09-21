using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class Method_Parameter_Modifiers
    {
        string str = "99";
        public void refMethod(ref string a)
        {
            var e = a;
            a = a + "-000";
        }

        public void outMethod(out string b)
        {
            b = "2";
        }
        public void paramsMethod(params int[] c)
        {
            for (int i = 0; i < 10; i++)
            {
                
            }
        }

        public void simpleMethod(out Director d)
        {
            d = new Director();
            d.Born = DateTime.Now.AddYears(-25);
        }


    }
}
