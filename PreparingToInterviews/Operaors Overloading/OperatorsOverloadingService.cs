using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class OperatorsOverloadingService
    {
        public OperatorsOverloadingService()
        {

        }

        private void ConvertionOperatorsOverloadingCall()
        {
            var c1 = new ConvertionOperatorsOverloading1(1, 4);
            var c2 = new ConvertionOperatorsOverloading2(6, 7);
            c1 = c2;
        }
    }
}
