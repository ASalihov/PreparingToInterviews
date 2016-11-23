using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Automapper
{
    public static class Extensions
    {
        public static T ConvertTo<T>(this object o)
        {
            return Mapper.Map<object, T>(o);
        }
    }
}
