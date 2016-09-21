using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class Human
	{
		public string Name { get; set; }

        public override string ToString()
        {
            return "FuckYou!";
        }
	}
    public static class HumanExtensions
    {
        public static string DisplayName(this Human hum)
        {
            return hum.Name;
        }
    }
    public static class Int32Extensions
    {
        public static string ToString(this Int32 i)
        {
            return "FuckOff!";
        }
    }
}
