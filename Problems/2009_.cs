using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2009. Minimum Number of Operations to Make Array Continuous
//    You are given an integer array nums.In one operation, you can replace any element in nums with any integer.

//    nums is considered continuous if both of the following conditions are fulfilled:


//    All elements in nums are unique.
//    The difference between the maximum element and the minimum element in nums equals nums.length - 1.
//For example, nums = [4, 2, 5, 3] is continuous, but nums = [1, 2, 3, 5, 6] is not continuous.

//    Return the minimum number of operations to make nums continuous.
    internal class _2009_
    {
        public int MinOperations(int[] nums)
        {
            Array.Sort(nums);
            List<int> list = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                list.Add(nums[i]);
            }

            int max = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int target = list[i] + nums.Length - 1;
                int index = list.BinarySearch(target);

                if (index < 0)
                    index = (~index) - 1;

                max = Math.Max(max, index - i + 1);
            }

            return nums.Length - max;
        }
    }
}
