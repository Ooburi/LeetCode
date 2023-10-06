using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //343. Integer Break
    //Given an integer n, break it into the sum of k positive integers, where k >= 2, and maximize the product of those integers.

    //Return the maximum product you can get.
    internal class _343_IntegerBreak
    {
        public int IntegerBreak(int n)
        {
            if (n <= 3) return n - 1;
            if (n % 3 == 0) return (int)Math.Pow(3, n / 3);
            if (n % 3 == 1) return (int)Math.Pow(3, n / 3 - 1)*4;
            else return (int)Math.Pow(3, n / 3)*2;
        }

       
    }
}
