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
                Name = "Metallica",
                GenreId = 1,
                IsAcive = true
            };
            using (var context = new Context())
            {
                context.Database.Log = Console.WriteLine;
                context.Bands.Add(band);
                context.SaveChanges();
            }
        }
    }
}
