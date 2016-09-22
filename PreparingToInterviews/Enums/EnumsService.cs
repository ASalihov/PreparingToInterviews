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
            FunWithFlags();
            //DisplaySomeStuff();
        }

        private void FunWithFlags()
        {
            var days = DaysOfWeek.monday | DaysOfWeek.sunday | DaysOfWeek.tuesday;
            Console.WriteLine(days);
            Console.WriteLine(days & DaysOfWeek.thursday);
        }

        private void DisplaySomeStuff()
        {
            TestEnum c;
            Enum.TryParse("2", false, out c);
            Console.WriteLine("C - " + c);


            var en = (short)TestEnum.one;
            Console.WriteLine(Enum.GetUnderlyingType(typeof(TestEnum)));
        }


    }
}
