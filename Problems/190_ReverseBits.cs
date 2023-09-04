using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //190. Reverse Bits
    //Reverse bits of a given 32 bits unsigned integer.
    internal class _190_ReverseBits
    {
        public static uint reverseBits(uint n)
        {
            uint reversed = 0;
            for (int i = 0; i < 32; i++)
            {
                reversed = reversed << 1;
                if (n % 2 == 1)
                    reversed++;
                n = n >> 1;
            }
            return reversed;
        }
    }
}
