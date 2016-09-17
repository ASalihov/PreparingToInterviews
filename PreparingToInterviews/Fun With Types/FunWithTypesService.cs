using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace PreparingToInterviews
{
    public class FunWithTypesService
    {
        public FunWithTypesService()
        {

        }

        private void DoSomeStuff()
        {
            MyStaticClass.O = 4;
            Console.WriteLine("static property - " + MyStaticClass.O);
        }

        private void FunWithValueTypes()
        {
            Console.WriteLine("*************types casting****************" + Environment.NewLine);
            byte by = 100;
            for (int i = 0; i < 100; i++)
            {
                unchecked
                {
                    by += 50;
                }
            }
            Console.WriteLine(by.GetType());
        }

        private void FunWithRefTypes()
        {
            Object s = "string";
            Object s1 = "ring";
            Type[] types = new Type[] { s1.GetType() };
            MethodInfo method = s.GetType().GetMethod("Contains", types);
            Object[] arguments = new Object[] { s1 };
            Console.WriteLine("Method INVOKE " + method.Invoke(s, arguments));
        }
    }
}
