using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1512. Number of Good Pairs
    //Given an array of integers nums, return the number of good pairs.

    //A pair(i, j) is called good if nums[i] == nums[j] and i<j.
    internal class _1512_
    {
        public int NumIdenticalPairs(int[] nums)
        {
            
            int result = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j=i+1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i]) result++;
                }
            }
            return result;
        }
    }
}
