using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PreparingToInterviews
{
    public class Helpers
    {
        public class BoldInt32 : IFormatProvider, ICustomFormatter
        {

            public object GetFormat(Type formatType)
            {
                return this;
                //return Thread.CurrentThread.CurrentCulture.GetFormat(formatType);
            }

            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                String s;

                IFormattable formattable = arg as IFormattable;
                if (formattable == null)
                {
                    s = arg.ToString();
                }
                else
                {
                    s = formattable.ToString(format, formatProvider);
                }

                if (arg.GetType() == typeof(DateTime))
                {
                    s = formattable.ToString(format, new CultureInfo("en-US"));
                }

                if (arg.GetType() == typeof(Int32))
                {
                    return "<B>" + arg + "</B>";
                }
                return s;
            }
        }
    }
}
