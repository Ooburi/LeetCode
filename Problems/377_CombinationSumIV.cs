using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //377. Combination Sum IV

    //Given an array of distinct integers nums and a target integer target, return the number of possible combinations that add up to target.

    //The test cases are generated so that the answer can fit in a 32-bit integer.
    internal class _377_CombinationSumIV
    {
        public static int CombinationSum4(int[] nums, int target)
        {
            //if (target == 0) return 1;
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (target - nums[i] < 0) continue;
            //    sum += CombinationSum4(nums, target - nums[i]);
            //}
            //return sum;
            int[] dp = new int[target+1];
            dp[0] = 1;

            for(int i = 1; i < dp.Length; i++)
            {
                int sum = 0;
                
                foreach(int x in nums)
                {
                    if(i-x>=0 && i-x<=i)
                    {
                        sum += dp[i - x];
                    }
                }
                dp[i] = sum;
            }
            return dp[target];
        }
    }
}
