using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public partial class Partial
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public partial class Partial
    {
        public Partial()
        {
            this.a = 1;
            this.b = 2;
            this.c = 3;
        }
        public int c { get; set; }
    }

    public static class MyStaticClass
    {
        private static int o;
        public static int O { get { return o; } set { o = value; } }
        static MyStaticClass()
        {
            o = 2;
        }
    }
    public class Director
    {
        public DateTime Born { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
    }

    public enum Genre
    {
        Horror = 1,
        Triller = 2,
        Drama = 3
    }
    public class Movie : IComparable<Movie>, IEquatable<Movie>
    {
        public int ReleaseYear { get; set; }
        public Director Director { get; set; }
        public Genre Genre { get; set; }

        public void FuckTheSystem()
        {
            Console.WriteLine("FUCKTHESYSTEM!!!!");
        }

        public bool Equals(object other)
        {
            if (other == null) return false;

            if (object.ReferenceEquals(this, other)) return true;

            if (this.GetType() != other.GetType()) return false;

            return base.Equals(other);
        }

        public int CompareTo(Movie other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(Movie other)
        {
            throw new NotImplementedException();
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
