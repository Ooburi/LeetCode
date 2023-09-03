using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //169. Majority Element

    //Given an array nums of size n, return the majority element.

    //The majority element is the element that appears more than ⌊n / 2⌋ times.
    //You may assume that the majority element always exists in the array.
    internal class _169_MajorityElement
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 0;
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
                if (dict[nums[i]] > dict[max]) max = nums[i];
            }
            return max;
        }
    }
}
