using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //456. 132 Pattern
    //Given an array of n integers nums, a 132 pattern is a
    //subsequence of three integers nums[i], nums[j] and nums[k] such that i<j<k and nums[i] < nums[k] < nums[j].


    //Return true if there is a 132 pattern in nums, otherwise, return false.
    internal class _456_
    {
        public static bool Find132pattern(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int t = int.MinValue;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] < t) return true;
                while (stack.Count > 0 && stack.Peek() < nums[i])
                {
                    t = stack.Pop();
                }
                stack.Push(nums[i]);
            }
            return false;
        }
    }
}
