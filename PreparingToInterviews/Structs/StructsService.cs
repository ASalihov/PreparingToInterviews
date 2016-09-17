using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace PreparingToInterviews
{
    public class StructsService
    {
        public StructsService()
        {

        }

        private void DoComparisonJob()
        {
            MyStruct1 xx = new MyStruct1();
            MyStruct1 yy = new MyStruct1();
            Console.WriteLine(xx.Equals(yy));

            MyStruct1 ms1 = new MyStruct1 { MyProperty1 = 100, MyProperty2 = 2 };
            MyStruct1 ms2 = new MyStruct1 { MyProperty1 = 1, MyProperty2 = 1003 };
            object ms3 = ms2;
            object ms4 = null;
            Console.WriteLine("MyStruct1 EQUALITY  /  " + (ms1 != ms2));

            var strct = new str();

            var strct1 = new str1();
            strct.getY = 511;
            Console.WriteLine("strct's overriden ToString() - " + strct);
            Console.WriteLine("strct1's NOT overriden ToString() - " + strct1);
            Console.WriteLine("strct.getY - " + strct.getY);
            Console.WriteLine("getX bytes - ");
            Console.WriteLine("str struct SIZE - " + Marshal.SizeOf(strct1));

            Console.WriteLine("strct.getZ - " + strct.getZ);

        }
    }
}
