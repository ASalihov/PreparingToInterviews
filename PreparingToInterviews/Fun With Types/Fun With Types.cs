﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
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
}
