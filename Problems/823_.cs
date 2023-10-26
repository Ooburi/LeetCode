using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //823. Binary Trees With Factors
    //    Given an array of unique integers, arr, where each integer arr[i] is strictly greater than 1.

    //We make a binary tree using these integers, and each number may be used for any number of times.
    //Each non-leaf node's value should be equal to the product of the values of its children.

    //Return the number of binary trees we can make.The answer may be too large so return the answer modulo 109 + 7.
    internal class _823_
    {
        private const int MOD = 1000000007;
        public int NumFactoredBinaryTrees(int[] arr)
        {
            Array.Sort(arr);
            HashSet<int> s = new HashSet<int>(arr);
            Dictionary<int, long> dp = new Dictionary<int, long>();
            foreach (int x in arr) dp[x] = 1;

            foreach (int i in arr)
            {
                foreach (int j in arr)
                {
                    if (j > Math.Sqrt(i)) break;
                    if (i % j == 0 && s.Contains(i / j))
                    {
                        long temp = dp[j] * dp[i / j];
                        dp[i] = (dp[i] + (i / j == j ? temp : temp * 2)) % MOD;
                    }
                }
            }

            long result = 0;
            foreach (long val in dp.Values)
            {
                result = (result + val) % MOD;
            }
            return (int)result;
        }
    }
}
