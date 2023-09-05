using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //191. Number of 1 Bits
    //Write a function that takes the binary representation
    //of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).
    internal class _191_NumberOf1Bits
    {
        public int HammingWeight(uint n)
        {
            //int count = 0;
            //for (int i = 16; i > 0; i--)
            //{
            //    count += (int)n & 1;
            //    n = n >> 1;
            //}
            //return count;
            return System.Numerics.BitOperations.PopCount(n);
        }
    }
}
