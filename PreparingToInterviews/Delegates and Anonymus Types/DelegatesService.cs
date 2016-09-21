using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class DelegatesService
    {
        public DelegatesService()
        {

        }

        private void DisplaySomeStuff()
        {
            Delegates.ShowInfo(1, Delegates.SomeMeth);
        }

        private void AnonTypes()
        {
            var anon = new { a = 1, b = "2", c = new Human() };
            Console.WriteLine("anon.ToString() - " + anon.a);
        }
    }
}
