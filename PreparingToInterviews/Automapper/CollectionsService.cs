using PreparingToInterviews.Automapper;
using AutoMapper;
using System;
using System.Collections.Generic;

namespace PreparingToInterviews
{
    public class AutomapperService
    {
        public AutomapperService()
        {
            Configuration.Config();
            CreateInstances();
            //SimpleMapping();
            //MappingViaExtensions();
            CollectionsMapping();
        }

        private void CollectionsMapping()
        {
            var someCollection = Mapper.Map<List<ClassesTwo>, List<ClassesOne>>(Twoes);
            foreach (var item in someCollection)
            {
                Console.WriteLine(item);
            }
        }

        public ClassesOne ClassOne { get; set; }
        public ClassesTwo ClassTwo { get; set; }
        public List<ClassesOne> Ones { get; set; }
        public List<ClassesTwo> Twoes { get; set; }

        private void CreateInstances()
        {
            ClassOne = new ClassesOne
            {
                MyProperty1 = 1,
                MyProperty2 = 2
            };

            ClassTwo = new ClassesTwo
            {
                MyProperty1 = 1100,
                MyProperty2 = 2200
            };
            Ones = new List<ClassesOne> { ClassOne };
            Twoes = new List<ClassesTwo> { ClassTwo };
        }

        private void MappingViaExtensions()
        {
            var someClass = ClassOne.ConvertTo<ClassesTwo>();
            Console.WriteLine(someClass);
        }

        private void SimpleMapping()
        {
            ClassTwo = Mapper.Map<ClassesOne, ClassesTwo>(ClassOne);

            var someClass = ClassOne.ToClassTwo();
            Console.WriteLine(someClass);
        }
    }
}
