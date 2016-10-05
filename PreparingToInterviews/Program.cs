#define TEST_CONDITIONAL_COMPILAION
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace PreparingToInterviews
{
    class Program
    {
        static void Main(string[] args)
        {

            Debug.Fail("fuck off!!!", "off fuck!");
#if TEST_CONDITIONAL_COMPILAION
            //var service = new GenericService<GenericsService>();
            var service = new GenericService<ExceptionsService>();

            Console.ReadLine();
#endif
        }

    }
}
