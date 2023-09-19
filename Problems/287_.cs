using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //287. Find the Duplicate Number
    //Given an array of integers nums containing n + 1 integers where each integer is in the range[1, n] inclusive.

    //There is only one repeated number in nums, return this repeated number.


    //You must solve the problem without modifying the array nums and uses only constant extra space.
    internal class _287_
    {
        public static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            } while (slow != fast);

            slow = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return slow;
        }
    }
}
