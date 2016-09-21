using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class ValAndRefTypesService
    {
        public ValAndRefTypesService()
        {

        }

        private void ValAndRefTypesTest()
        {
            str str = new str();
            Int32 x = str.x;
            Console.WriteLine(x);
            Value_And_Reference_Types vrt = new Value_And_Reference_Types();

            vrt.TestValRefTypes();
        }

        private void AsAndIsTest()
        {
            var asis = new AS_and_IS();

            var is_res = asis.Is_CheckIfInt(1);
            var as_res = asis.As_ConvertToString("1");

            Console.WriteLine("*************** ----- ********************");


            Console.WriteLine("Is_CheckIfInt - " + is_res);
            Console.WriteLine("As_ConvertToString - " + as_res);
        }
    }
}
