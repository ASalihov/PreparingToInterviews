using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLEARN.RockBandsDomain.Classes;
using EFLEARN.RockBandsDomain.DataModel;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AddBand();
            Console.Read();
        }

        public static void AddBand()
        {
            Band band = new Band()
            {
                Name = "Dream Theatre",
                GenreId = 1,
                IsActive = true,
                ModifiedOn = DateTime.Now,
                CreatedOn = DateTime.Now
            };
            using (var context = new ConsoleContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Bands.Add(band);
                context.SaveChanges();
            }
        }
    }
}
