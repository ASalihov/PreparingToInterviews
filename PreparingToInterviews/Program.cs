using System;
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

            //var service = new GenericService<GenericsService>();
            var service = new GenericService<EnumsService>();

            Console.ReadLine();
        }

    }
}
