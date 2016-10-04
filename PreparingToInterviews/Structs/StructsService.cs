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
            MyStruct2 xx = new MyStruct2();
            MyStruct2 yy = new MyStruct2();
            Console.WriteLine(xx.Equals(yy));

            MyStruct2 ms1 = new MyStruct2 { MyProperty1 = 100, MyProperty2 = 2 };
            MyStruct2 ms2 = new MyStruct2 { MyProperty1 = 1, MyProperty2 = 1003 };
            object ms3 = ms2;
            object ms4 = null;
            Console.WriteLine("MyStruct1 EQUALITY  /  " + (ms1 != ms2));

            var strct = new MyStruct();

            var strct1 = new MyStruct1();
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
