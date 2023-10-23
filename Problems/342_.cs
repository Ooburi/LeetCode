using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //342. Power of Four
    //Given an integer n, return true if it is a power of four.Otherwise, return false.


    //An integer n is a power of four, if there exists an integer x such that n == 4^x.
    internal class _342_
    {
        public bool IsPowerOfFour(int n)
        {
            while (n > 1)
            {
                int x = n & 3;
                if (x > 0) return false;
                n = n >> 2;
            }

            return n == 1;
        }
    }
}
