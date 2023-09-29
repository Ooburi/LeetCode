using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //896. Monotonic Array
    //    An array is monotonic if it is either monotone increasing or monotone decreasing.

    //An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j]. An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].

    //Given an integer array nums, return true if the given array is monotonic, or false otherwise.
    internal class _896_
    {
        public bool IsMonotonic(int[] nums)
        {
            if (nums.Length == 1) return true;
            bool up = nums[0] <= nums[nums.Length-1];
            for(int i = 0; i < nums.Length-1; i++)
            {
                if (up && nums[i] > nums[i + 1]) return false;
                if (!up && nums[i] < nums[i + 1]) return false;
            }
            return true;
        }
    }
}
