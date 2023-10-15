using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1269. Number of Ways to Stay in the Same Place After Some Steps
    //You have a pointer at index 0 in an array of size arrLen.
    //At each step, you can move 1 position to the left, 1 position
    //to the right in the array, or stay in the same place(The pointer
    //should not be placed outside the array at any time).

    //Given two integers steps and arrLen, return the number
    //of ways such that your pointer is still at index 0 after exactly
    //steps steps.Since the answer may be too large, return it modulo 109 + 7.
    internal class _1269_
    {
        public int NumWays(int steps, int arrLen)
        {
            const int MOD = 1000000007;

            int maxIndex = Math.Min(steps / 2, arrLen - 1);

            int[][] dp = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                dp[i] = new int[maxIndex + 1];
            }
            dp[0][0] = 1;

            for (int step = 1; step <= steps; step++)
            {
                int current = step % 2;
                int prev = (step - 1) % 2;

                for (int index = 0; index <= maxIndex; index++)
                {
                    dp[current][index] = dp[prev][index] % MOD;

                    if (index > 0)
                    {
                        dp[current][index] = (dp[current][index] + dp[prev][index - 1]) % MOD;
                    }

                    if (index < maxIndex)
                    {
                        dp[current][index] = (dp[current][index] + dp[prev][index + 1]) % MOD;
                    }
                }
            }

            return dp[steps % 2][0];
        }
    }
}
