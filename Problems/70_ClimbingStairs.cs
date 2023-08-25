using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //70. Climbing Stairs

    //    You are climbing a staircase.It takes n steps to reach the top.
    //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

    //Example 1:

    //Input: n = 2
    //Output: 2
    //Explanation: There are two ways to climb to the top.
    //1. 1 step + 1 step
    //2. 2 steps

    //    Constraints:
    //1 <= n <= 45
    internal class _70_ClimbingStairs
    {
        Dictionary<int, int> _climbingCache = new()
        {
            {1,1 },
            {2,2 },
            {3,3 },
            {4,5 },
            {5,8 },
            {6,13 }
        };
        public static int ClimbStairs(int n)
        {
            if (n <= 3) return n;
            List<int> fib = new();
            fib.AddRange(new int[] { 0, 1, 2 });

            for(int i = 3; i <= n; i++)
            {
                fib.Add(fib[i - 1] + fib[i - 2]);
            }
            return fib[n];
        }
    }
}
