using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class ConvertionOperatorsOverloading1
    {
        public ConvertionOperatorsOverloading1(int i, int y)
        {
            this._i = i;
            this._i1 = y;
        }
        public ConvertionOperatorsOverloading1(ConvertionOperatorsOverloading2 coo2)
        {
            i = coo2.y;
            i1 = coo2.y1;
        }
        private int _i;
        private int _i1;

        public int i { get { return this._i; } set { this._i = value; } }
        public int i1 { get { return this._i1; } set { this._i1 = value; } }

        public static implicit operator ConvertionOperatorsOverloading1(ConvertionOperatorsOverloading2 coo2)
        {
            return new ConvertionOperatorsOverloading1(coo2);
        }
    }
    public class ConvertionOperatorsOverloading2
    {
        public ConvertionOperatorsOverloading2(int i, int y)
        {
            this._y = i;
            this._y1 = y;
        }
        private int _y;
        private int _y1;

        public int y { get { return this._y; } set { this._y = value; } }
        public int y1 { get { return this._y1; } set { this._y1 = value; } }

    }
}
