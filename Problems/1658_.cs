using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1658. Minimum Operations to Reduce X to Zero
    //You are given an integer array nums and an integer x.In one operation,
    //you can either remove the leftmost or the rightmost element from the array
    //nums and subtract its value from x.Note that this modifies the array for future operations.

    //Return the minimum number of operations to reduce x to exactly 0 if it is possible, otherwise, return -1.
    internal class _1658_
    {
        public static int MinOperations(int[] nums, int x)
        {

            //int left = 0, right = nums.Length - 1;
            //int count = 0;
            //while (x>0 && left<nums.Length && right>=0)
            //{
            //    if (nums[left] > x && nums[right] > x || right<left) break;
            //    if(nums[left] <= x && nums[left] >= nums[right])
            //    {
            //        x-=nums[left++];
            //        count++;
            //    } else if(nums[right] <= x)
            //    {
            //        x -= nums[right--];
            //        count++;
            //    }
            //}
            //if (count == 0 || x>0) count = -1;
            //return count;
            int target = -x, n = nums.Length;
            foreach (int num in nums) target += num;

            if (target == 0) return n;

            int maxLen = 0, curSum = 0, left = 0;

            for (int right = 0; right < n; ++right)
            {
                curSum += nums[right];
                while (left <= right && curSum > target)
                {
                    curSum -= nums[left];
                    left++;
                }
                if (curSum == target)
                {
                    maxLen = Math.Max(maxLen, right - left + 1);
                }
            }

            return maxLen != 0 ? n - maxLen : -1;
        }
//        Key Data Structures:
//max_len: An integer to store the length of the longest subarray that can be excluded to make the sum equal to x.
//cur_sum: An integer to store the sum of elements in the current subarray.
//Enhanced Breakdown:
//Initialize and Calculate the Target:

//Compute target = sum(nums) - x, as we're interested in finding a subarray with this sum.
//Initialize max_len, cur_sum, and left to 0.
//Check for Edge Cases:

//If target is zero, it means we need to remove all elements to make the sum equal to x.In this case, return the total number of elements, n.
//Traverse the Array with Two Pointers:

//Iterate through nums using a right pointer.
//Update cur_sum by adding the current element nums[right].
//Sliding Window Adjustment:

//If cur_sum exceeds target, slide the left pointer to the right by one position and decrease cur_sum by nums[left].
//Update Max Length:

//If cur_sum matches target, update max_len with the length of the current subarray, which is right - left + 1.
//Conclude and Return:

//After the loop, if max_len is non-zero, return n - max_len.Otherwise, return -1, indicating it's not possible to reduce x to zero.
    }
}
