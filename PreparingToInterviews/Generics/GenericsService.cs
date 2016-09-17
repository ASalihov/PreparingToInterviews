using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Generics
{
    public class GenericsService
    {
        public GenericsService()
        {

        }

        private void DoSomeStuff()
        {
            var gen = new Generics<Human>();
            Generics<Human>.SameDataLinkedList();
        }
    }
}
