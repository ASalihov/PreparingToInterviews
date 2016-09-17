using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparingToInterviews
{
    public class CodeExamplesService
    {
        public CodeExamplesService()
        {
            BitArrayCall();
        }

        private void BitArrayCall()
        {
            var bitArr = new BitArray(18);
            //bitArr[8] = true;
            bitArr[9] = true;
            bitArr[10] = false;
            bitArr[12] = true;
            bitArr[13] = true;
            bitArr[14] = true;
        }

        private void GetBinaryStringCall()
        {
            Console.WriteLine(GetBinaryString.GetIntBinaryString(60));
        }

        private void FizzBuzzCall()
        {

        }
    }
}
