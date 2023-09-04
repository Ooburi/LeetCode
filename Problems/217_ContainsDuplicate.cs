using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //217. Contains Duplicate

    //Given an integer array nums, return true if any value appears at least twice
    //in the array, and return false if every element is distinct.
    internal class _217_ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Distinct<int>().Count() != nums.Length;
        }
    }
}
