using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public interface Interfaces
    {
        void meth();
    }

    public class Implementations : Interfaces, IComparable<Movie>
    {
        

        public virtual void meth()
        {
            throw new NotImplementedException();
        }

        int IComparable<Movie>.CompareTo(Movie other)
        {
            throw new NotImplementedException();
        }
    }

    public class Derived : Implementations, Interfaces
    {
        public Int32 i = 1;
        new public void meth()
        {
            base.meth();
        }
    }
}
