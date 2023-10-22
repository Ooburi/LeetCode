using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1793. Maximum Score of a Good Subarray
    //You are given an array of integers nums(0-indexed) and an integer k.

    //The score of a subarray (i, j) is defined as min(nums[i], nums[i + 1], ..., nums[j]) * (j - i + 1).
    //A good subarray is a subarray where i <= k <= j.

    //Return the maximum possible score of a good subarray.
    internal class _1793_
    {
        public int MaximumScore(int[] nums, int k)
        {
            
                int left = k, right = k;
                int min_val = nums[k];
                int max_score = min_val;

                while (left > 0 || right < nums.Length - 1)
                {
                    if (left == 0 || (right < nums.Length - 1 && nums[right + 1] > nums[left - 1]))
                    {
                        right++;
                    }
                    else
                    {
                        left--;
                    }
                    min_val = Math.Min(min_val, Math.Min(nums[left], nums[right]));
                    max_score = Math.Max(max_score, min_val * (right - left + 1));
                }

                return max_score;
        }
    }
}
