using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class FizzBuzz
    {
        public static void WriteLineImplementation()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FIZZ_BUZZ");
                }
                else
                    Console.WriteLine(i);
            }
        }

        public static void WriteImplementation()
        {
            for (int j = 1; j < 101; j++)
            {
                if (j % 3 == 0)
                    Console.Write("FIZZ");
                if (j % 5 == 0)
                    Console.Write("BUZZ");
                if (j % 3 != 0 && j % 5 != 0)
                    Console.Write(j);
                Console.WriteLine("");
            }
        }

        public static void IterateAndCompareImplementation()
        {
            for (int a = 1, b = 1, c = 1; a < 101; a++, b++, c++)
            {
                if (b == 3)
                    b = 0;
                if (c == 5)
                    c = 0;
                if (b != 0 && c != 0)
                    Console.Write(a);
                if (b == 0)
                    Console.Write("FIZZ");
                if (c == 0)
                    Console.Write("BUZZ");

                Console.WriteLine("");
            }
        }

    }
}
