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
            //EnumsComparison();
            //EnumExtensionMeth();
            FunWithFlags();
            //DisplaySomeStuff();
        }

        private void EnumsComparison()
        {
            var o = 1;
            if (o == ((int)TestEnum.one | (int)TestEnum.two))
            {
                Console.WriteLine("match!");
            }
        }

        private void EnumExtensionMeth()
        {
            var en = DaysOfWeek.friday;
            en.Ext();
        }



        private void FunWithFlags()
        {
            //GetFlags(DaysOfWeek.sunday & DaysOfWeek.monday);
            GetFlags(DocumentButtonType.UserAgreeRequiresDS);

            //var days = DaysOfWeek.monday | DaysOfWeek.friday | DaysOfWeek.wednesday;
            //Console.WriteLine(days.ToString());
            //Console.WriteLine(days ^ DaysOfWeek.monday);

            //days = days ^ DaysOfWeek.monday;
            //Console.WriteLine(days.ToString());
            //days = days | DaysOfWeek.saturday;
            //Console.WriteLine(days.ToString());
        }

        private void GetFlags(DocumentButtonType flags)
        {
            var _documentButtonType = DocumentButtonType.UserAgreeRequiresDS;
            string requireDSText = "requiresDS";
            var HtmlClasses = $"btn btn-success {(_documentButtonType == DocumentButtonType.UserAgreeRequiresDS ? requireDSText : string.Empty)}";
            Console.WriteLine(HtmlClasses);
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
