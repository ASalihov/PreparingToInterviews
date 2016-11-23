using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews.Automapper
{
    public class Configuration
    {
        public static void Config()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<ClassesOne, ClassesTwo>();
                cfg.CreateMap<ClassesTwo, ClassesOne>();
                cfg.CreateMap<List<ClassesTwo>, List<ClassesOne>>();
            });
        }
    }
}
