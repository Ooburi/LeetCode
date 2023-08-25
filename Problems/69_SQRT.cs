using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //69. Sqrt(x)
    //Given a non-negative integer x, return the square root of x rounded down to the nearest integer.
    //The returned integer should be non-negative as well.
    //You must not use any built-in exponent function or operator.
    //For example, do not use pow(x, 0.5) in c++ or x ** 0.5 in python.
    internal class _69_SQRT
    {
        public static int MySqrt(int x)
        {
            long a = 0;
            while (true)
            {
                if (a * a > x) return (int)--a;
                if (a * a == x) return (int)a;
                a++;
            }
        }
    }
}
