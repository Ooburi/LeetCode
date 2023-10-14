using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2742. Painting the Walls
    //You are given two 0-indexed integer arrays, cost and time, of size n
    //representing the costs and the time taken to paint n different walls respectively.
    //There are two painters available:

    //A paid painter that paints the ith wall in time[i] units of time and takes cost[i] units of money.
    //A free painter that paints any wall in 1 unit of time at a cost of 0. But the free painter can only
    //be used if the paid painter is already occupied.
    //Return the minimum amount of money required to paint the n walls.
    internal class _2742_
    {
        long[,] dp;
        public int PaintWalls(int[] cost, int[] time)
        {
            dp = new long[cost.Length + 1, cost.Length + 1];
            for (int i = 0; i < dp.GetLength(0); i++)
            {
                for (int j = 0; j < dp.GetLength(1); j++)
                {
                    dp[i, j] = -1;
                }
            }

            long res = F(cost, time, 0, 0);
            return (int)res;
        }
        public long F(int[] cost, int[] time, int i, int t)
        {
            if (t >= cost.Length)
            {
                return 0;
            }
            if (i == cost.Length)
            {
                return int.MaxValue;
            }
            if (dp[i, t] != -1)
            {
                return dp[i, t];
            }

            dp[i, t] = Math.Min(cost[i] + F(cost, time, i + 1, t + 1 + time[i]), F(cost, time, i + 1, t));
            return dp[i, t];
        }
    }
}
