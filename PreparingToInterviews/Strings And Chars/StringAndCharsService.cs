using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PreparingToInterviews
{
    public class StringAndCharsService
    {
        Display wr = new Display(Console.WriteLine);
        public StringAndCharsService()
        {
            IFormatProvider();
            //StringBuilder();
            //CompareStrings();
            //UseSpeciaCharacters;
            //DispayStringStuff();
        }

        private void IFormatProvider()
        {
            var sb = new StringBuilder();
            sb.AppendFormat(new Helpers.BoldInt32(), "{1} - {0} - {2}", DateTime.Now, 123, "Akmal");
            wr(sb);
        }

        private void StringBuilder()
        {
            var sb = new StringBuilder("12345678900000000000000", 60);
        }

        private void CompareStrings()
        {
            var res = Math.Sign(String.Compare("1", "2"));
            wr(res);
        }

        private void UseSpeciaCharacters()
        {
            Console.Write("Some string {0} {1}", 1, 3);
        }

        private void DispayStringStuff()
        {
            var str1 = "fuck";
            var str2 = "fuck";
            var charArr = new Char[50];
            str1.CopyTo(1, charArr, 2, 2);
            wr(charArr);
            wr(Object.Equals(str1, str2));
            wr(String.IsInterned(str: "123"));

            wr(CultureInfo.CurrentCulture);
        }

        private void DispayCharStuff()
        {
            var inst = new Strings_And_Chars();

            var c = unchecked ((Char)65);

            Console.WriteLine(c);
            Console.WriteLine(Convert.ToByte(c));
            Console.WriteLine((Char)1);
        }


        public override string ToString()
        {
            return "хули смотришь?!";
        }
    }
}
