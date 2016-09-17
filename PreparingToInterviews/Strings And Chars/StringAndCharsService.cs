using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class StringAndCharsService
    {
        public StringAndCharsService()
        {
            DispayStuff();
        }

        private void DispayStuff()
        {
            var inst = new Strings_And_Chars();

            var text = "text";

            var boo = inst.ch.Equals('b');
            Console.Write(boo);

            var isDigit = char.IsDigit(text[1]);

            var a = text[1];

            char.ToLowerInvariant(a);
        }
    }
}
