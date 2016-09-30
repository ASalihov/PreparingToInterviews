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
            EnumExtensionMeth();
            //FunWithFlags();
            //DisplaySomeStuff();
        }

        private void EnumExtensionMeth()
        {
            var en = DaysOfWeek.friday;
            en.Ext();
        }



        private void FunWithFlags()
        {
            var days = DaysOfWeek.monday | DaysOfWeek.friday | DaysOfWeek.wednesday;
            Console.WriteLine(days.ToString());
            Console.WriteLine(days ^ DaysOfWeek.monday);
            

            days = days ^ DaysOfWeek.monday;
            Console.WriteLine(days.ToString());
            days = days | DaysOfWeek.saturday;
            Console.WriteLine(days.ToString());

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
