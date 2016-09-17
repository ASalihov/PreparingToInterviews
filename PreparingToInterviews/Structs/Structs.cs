using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace PreparingToInterviews
{
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

    public struct MyStruct1// : IEquatable<MyStruct1>
    {
        /*

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (this.MyProperty1 == ((MyStruct1)obj).MyProperty2) return true;

            return base.Equals(obj);
        }*/
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

        public static bool operator ==(MyStruct1 ms1, MyStruct1 ms2)
        {
            if (ms1.MyProperty1 == ms2.MyProperty2)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MyStruct1 ms1, MyStruct1 ms2)
        {
            if (ms1.MyProperty1 != ms2.MyProperty2)
            {
                return true;
            }
            return false;
        }
        /*
        public bool Equals(MyStruct1 other)
        {
            if (this.MyProperty1 == other.MyProperty2) return true;
            return base.Equals(other);
        }*/
    }
}
