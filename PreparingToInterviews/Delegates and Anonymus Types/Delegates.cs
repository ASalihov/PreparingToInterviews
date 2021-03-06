﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{

    internal delegate void Feedback(Int32 value); 
    internal delegate string Feedback2(Int32 value, Int32 value2);

    public class Delegates
    {
        public static int SomeMeth(int x)
        {
            return x + 1;
        }
        public static void ShowInfo<Tr>(Tr x, Func<Tr, Tr> t)
        {
            Console.WriteLine("DELEGATE - " + t(x));
        }
    }
}
