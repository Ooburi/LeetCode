using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //905. Sort Array By Parity
    //Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

    //Return any array that satisfies this condition.
    internal class _905_
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int i = 0;
            int j = nums.Length - 1;
            while (i < j)
            {
                while (i < j && nums[i] % 2 == 0) i++;
                while (i < j && nums[j] % 2 == 1) j--;

                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
            return nums;
        }
    }
}
