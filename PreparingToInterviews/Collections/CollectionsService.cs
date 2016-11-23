using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class CollectionsService
    {
        public CollectionsService()
        {
            Arrays();
            //FunWithDictionaries();
        }

        private void Arrays()
        {
            int[] arr = { 10, 20, 40 };
            var res = arr.Aggregate(1000, (a, b) => { Console.WriteLine(a + " - " + b); return a - b; });
            Console.WriteLine(res);
        }

        private void FunWithDictionaries()
        {
            var dict = new Dictionary<string, int>()
            {
                //["123"] = 1
            };

            //Console.WriteLine(dict.);
        }
    }
}
