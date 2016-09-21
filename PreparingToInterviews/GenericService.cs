using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class GenericService<T> where T : new()
    {
        public GenericService()
        {
            var t = typeof(T);
            Console.WriteLine("###### " + t.Name.ToUpper() + " ######" + Environment.NewLine);
            var instance = new T();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("######################################");
        }
    }
}
