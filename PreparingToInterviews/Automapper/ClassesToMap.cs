using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Automapper
{
    public class ClassesOne
    {
        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }

        public override string ToString()
        {
            return "CLASS ONE:" + Environment.NewLine + "MyProperty1 - " + MyProperty1 + Environment.NewLine + "MyProperty2 - " + MyProperty2;
        }

        public ClassesTwo ToClassTwo()
        {
            return Mapper.Map<ClassesOne, ClassesTwo>(this);
        }
    }

    public class ClassesTwo
    {
        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }

        public override string ToString()
        {
            return "CLASS TWO:" + Environment.NewLine + "MyProperty1 - " + MyProperty1 + Environment.NewLine + "MyProperty2 - " + MyProperty2;
        }
    }
}
