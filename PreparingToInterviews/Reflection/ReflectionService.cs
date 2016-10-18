using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class ReflectionService
    {
        public ReflectionService()
        {
            CallGenericMethods();
        }

        private void CallGenericMethods()
        {
            Movie movie = new Movie();
            GetTypeProperties(movie);
        }

        private void GetTypeProperties<T>(T obj)
        {
            Console.WriteLine(typeof(T).Name.Replace("Mov", "Huyuv"));
        }



    }
}
