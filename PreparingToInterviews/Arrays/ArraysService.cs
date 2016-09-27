using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class ArraysService
    {
        public ArraysService()
        {
            DisplayStuff();
        }

        private void DisplayStuff()
        {
            String[,] arr = new string[2, 2] { { "1", "2"}, {"1", "2"} };
            String[][] arr2 = new string[][] { new string[] { "1", "2" }, new string[] { "1", "2" } };
            String[][] arr3 =  { new[] { "1", "2" }, new[] { "1", "2" } };

            foreach (var s in arr)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Environment.NewLine);
            foreach (var strings in arr2)
            {
                Console.WriteLine(strings);
            }
        }
    }
}
