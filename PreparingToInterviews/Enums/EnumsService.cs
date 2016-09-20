using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class EnumsService
    {
        public EnumsService()
        {
            DisplaySomeStuff();
        }

        private void DisplaySomeStuff()
        {
            var en = (short)TestEnum.one;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(TestEnum)));
        }


    }
}
