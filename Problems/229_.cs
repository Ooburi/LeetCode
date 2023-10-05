using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //229. Majority Element II
    //Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
    internal class _229_
    {
        public IList<int> MajorityElement(int[] nums)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                if (!count.ContainsKey(nums[i]))
                {
                    count[nums[i]] = 1;
                } else count[nums[i]]++;
            }

            return count.Where(e=>e.Value>nums.Length/3).Select(a=>a.Key).ToList();
        }
    }
}
