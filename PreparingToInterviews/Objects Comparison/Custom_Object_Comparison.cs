using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
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
}
