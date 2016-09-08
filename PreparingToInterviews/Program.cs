using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;

namespace PreparingToInterviews
{
    internal class B
    {
        public int a;
        public int b;
        public int c;
    }
    internal class D : B
    {
        public int d;
        public int j;
    }
    /*
    11000000011011
    110000

     * */
    [StructLayout(LayoutKind.Explicit)]
    public struct str
    {
        public int getX { get { return x; } set { this.x = value; } }
        public int getY { get { return y; } set { this.y = value; } }
        public int getZ { get { return z; } set { this.z = value; } }
        [FieldOffset(0)]
        public Int32 x;
        [FieldOffset(4)]
        public Int32 y;
        [FieldOffset(4)]
        public Int32 z;
        public override string ToString()
        {
            return "fuck you!";
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct str1
    {
        public byte a; // 1 byte
        public int b; // 4 bytes
        public int b1; // 4 bytes
        public int b2; // 4 bytes
        public short c; // 2 bytes
        public byte d; // 1 byte
        public byte d1; // 1 byte

        public void meth(int i)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var bitArr = new BitArray(18);
            bitArr[9] = true;
            var bbb = bitArr[8];

            Console.WriteLine("************* ANONYMUS TYPES ****************" + Environment.NewLine);

            var anon = new { a = 1, b = "2", c = new Human() };
            Console.WriteLine("anon.ToString() - " + anon.a);
            Console.WriteLine("************* ANONYMUS TYPES ****************" + Environment.NewLine);


            var c1 = new ConvertionOperatorsOverloading1(1, 4);
            var c2 = new ConvertionOperatorsOverloading2(6, 7);
            c1 = c2;
            Partial partial = new Partial();
            var t = partial.GetType();
            foreach (var item in t.GetProperties())
            {
                Console.WriteLine(item.Name);
            }


            MyStaticClass.O = 4;
            Console.WriteLine("static property - " + MyStaticClass.O);


            Object s = "string";
            Object s1 = "ring";
            Type[] types = new Type[] { s1.GetType() };
            MethodInfo method = s.GetType().GetMethod("Contains", types);
            Object[] arguments = new Object[] { s1 };
            Console.WriteLine("Method INVOKE " + method.Invoke(s, arguments));


            dynamic dy = new Movie();
            dy.FuckTheSystem();


            dynamic tt = new object();
            MyStruct1 xx = new MyStruct1();
            MyStruct1 yy = new MyStruct1();
            Console.WriteLine(xx.Equals(yy));

            Console.WriteLine(Math.Sign(Math.Sqrt(2 * 2 + 3 * 3)));
            Console.WriteLine(GetIntBinaryString(60));
            Console.WriteLine("************** boxing / unboxing ******************");

            Int32 i1 = 4;
            Console.WriteLine("override int32's ToString() method - " + i1.ToString());

            Console.WriteLine("**************C U R R E N T******************");

            //*************structs****************
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
            //strct.getY = 15;
            Console.WriteLine("strct.getZ - " + strct.getZ);

            Console.WriteLine("**************C U R R E N T******************");

            Console.WriteLine("*************types casting****************" + Environment.NewLine);
            byte by = 100;
            for (int i = 0; i < 100; i++)
            {
                unchecked
                {
                    by += 50;
                }
            }
            Console.WriteLine(by.GetType());
            B b1 = new D();
            B b2 = new B();

            D d1 = new D { d = 1, j = 2, a = 4, b = 5, c = 6 };
            B b3 = new B() { a = 10, b = 20, c = 30 };
            //D d2 = (D)b3;
            //D d2 = (D)b2;
            //D d3 = (D)new B();

            Console.WriteLine("*************val ref types test****************" + Environment.NewLine);




            str str = new str();
            Int32 x = str.x;
            Console.WriteLine(x);
            Value_And_Reference_Types vrt = new Value_And_Reference_Types();

            vrt.TestValRefTypes();

            Console.WriteLine("*************FIZZ BUZZ****************" + Environment.NewLine);
            /*for (int i = 1; i <= 100; i++)
            {
                if (i%3 == 0 && i%5 != 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else if (i%3 != 0 && i%5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }
                else if (i % 15 == 0)
                {
                    Console.WriteLine("FIZZ_BUZZ");
                }
                else
                    Console.WriteLine(i);
            }*/
            /*
            for (int j = 1; j < 101; j++)
            {
                if (j % 3 == 0)
                    Console.Write("FIZZ");
                if (j % 5 == 0)
                    Console.Write("BUZZ");
                if (j % 3 != 0 && j % 5 != 0)
                    Console.Write(j);
                Console.WriteLine("");
            }*/

            for (int a = 1, b = 1, c = 1; a < 101; a++, b++, c++)
            {
                if (b == 3)
                    b = 0;
                if (c == 5)
                    c = 0;
                if (b != 0 && c != 0)
                    Console.Write(a);
                if (b == 0)
                    Console.Write("FIZZ");
                if (c == 0)
                    Console.Write("BUZZ");

                Console.WriteLine("");
            }

            Console.WriteLine("**************EXTENSIONS******************");

            Human man = new Human();
            man.Name = "John Smith";
            Console.WriteLine(man.DisplayName());
            Console.WriteLine(man.ToString());

            Console.WriteLine("******************************************");
            string ref_str = "ohoho";
            string out_str = "2";

            Director dir;
            var mpm = new Method_Parameter_Modifiers();

            mpm.refMethod(ref ref_str);
            mpm.outMethod(out out_str);
            mpm.simpleMethod(out dir);
            mpm.anotherMethod("qqq");
            Console.WriteLine("******************************************");
            var asis = new AS_and_IS();

            var is_res = asis.Is_CheckIfInt(1);
            var as_res = asis.As_ConvertToString("1");

            Console.WriteLine("*************** ----- ********************");

            Console.WriteLine("ref_str - " + ref_str);
            Console.WriteLine("out_str - " + out_str);
            Console.WriteLine("Is_CheckIfInt - " + is_res);
            Console.WriteLine("As_ConvertToString - " + as_res);

            Console.ReadLine();
        }


        static string GetIntBinaryString(int n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
}
