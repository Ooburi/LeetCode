using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //136. Single Number
    //Given a non-empty array of integers nums, every element appears twice except for one.Find that single one.
    //You must implement a solution with a linear runtime complexity and use only constant extra space.

    internal class _139_SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            if(nums.Length == 1) return nums[0];

            Dictionary<int, int> count = new Dictionary<int, int>();

            for(int i= 0; i < nums.Length; i++)
            {
                if (count.ContainsKey(nums[i]))
                {
                    count[nums[i]]++;
                } else
                {
                    count.Add(nums[i], 1);
                }
            }
            foreach(int i in count.Keys)
            {
                if (count[i] == 1) return count[i];
            }
            return 0;
        }
    }
}
