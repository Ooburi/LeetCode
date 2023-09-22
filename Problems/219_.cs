using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //219. Contains Duplicate II
    //Given an integer array nums and an integer k, return true if there are two distinct
    //indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
    internal class _219_
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            int l = 0, r = 0;
            HashSet<int> hash = new();

            while(r<nums.Length && l < nums.Length)
            {
                if(hash.Contains(nums[r])) return true;
                hash.Add(nums[r++]);
                if (r - l > k)
                {
                    hash.Remove(nums[l++]);
                }
            }
            return false;
        }
    }
}
