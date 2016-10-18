#define TEST_CONDITIONAL_COMPILAION
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class ExceptionsService
    {
        public ExceptionsService()
        {
            DoSomeStuff();
        }

        [Conditional("TEST_CONDITIONAL_COMPILAION")]
        private void DoSomeStuff()
        {
            Console.WriteLine("Fuck off!!!");
        }



    }
}
