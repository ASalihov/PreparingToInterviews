using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class AS_and_IS
    {
        public int Is_CheckIfInt(object obj)
        {
            if (obj is int)
            {
                return (int)obj;
            }
            return 0;
        }

        public string As_ConvertToString(object obj)
        {
            var variable = obj as string;
            if (variable != null)
            {
                return variable;
            }
            return "obj is not string!";
        }
    }
}
