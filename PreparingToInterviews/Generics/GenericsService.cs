using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class GenericsService
    {
        public GenericsService()
        {
            DisplayVarianceStuff();
        }

        private void DisplayVarianceStuff()
        {
            IVariance<D, B> d = new Variance();
            //Console.WriteLine(d.retunT().ToString());

            //IVariance<D, D> b = d;
            //Console.WriteLine(b.retunT().ToString());

        }

        private void DoSomeStuff()
        {
            var gen = new Generics<Human>();
            Generics<Human>.SameDataLinkedList();
        }


    }
}
