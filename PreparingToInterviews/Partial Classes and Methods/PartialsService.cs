using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Partial_Classes_and_Methods
{
    public class PartialsService
    {
        public PartialsService()
        {

        }

        private void DispaySomeStuff()
        {
            Partial partial = new Partial();
            var t = partial.GetType();
            foreach (var item in t.GetProperties())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
