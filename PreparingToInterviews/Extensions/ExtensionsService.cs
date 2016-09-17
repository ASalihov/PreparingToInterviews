using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Extensions
{
    public class ExtensionsService
    {
        public ExtensionsService()
        {
                
        }

        private void HumanExtensionsCall()
        {
            Human man = new Human();
            man.Name = "John Smith";
            Console.WriteLine(man.DisplayName());
            Console.WriteLine(man.ToString());
        }
    }
}
