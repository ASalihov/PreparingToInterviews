using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Method__Parameter_Modifiers
{
    public class MethodParameterModifiersService
    {
        public MethodParameterModifiersService()
        {

        }

        private void DisplayModifierssWork()
        {
            string ref_str = "ohoho";
            string out_str = "2";

            Director dir;
            var mpm = new Method_Parameter_Modifiers();

            mpm.refMethod(ref ref_str);
            mpm.outMethod(out out_str);
            mpm.simpleMethod(out dir);

            Console.WriteLine("ref_str - " + ref_str);
            Console.WriteLine("out_str - " + out_str);
        }
    }
}
