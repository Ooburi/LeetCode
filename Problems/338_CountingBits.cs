using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //338. Counting Bits
    //Given an integer n, return an array ans of length n + 1
    //such that for each i(0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.
    internal class _338_CountingBits
    {
        public int[] CountBits(int n)
        {
            //int[] bits = new int[n+1];

            //for(int i = 0; i <= n; i++)
            //{
            //    bits[i] = Convert.ToString(i,2).Where(s=>s=='1').Count();
            //}
            //return bits;
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                bits[i] = bits[i >> 1] + (i & 1);
            }
            return bits;
        }
    }
}
