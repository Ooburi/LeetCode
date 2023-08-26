using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    internal class _35_SearchInsertPosition
    {
        //35. Search Insert Position

        //Given a sorted array of distinct integers and a target value, return the index if the target is found.
        //If not, return the index where it would be if it were inserted in order.
        //You must write an algorithm with O(log n) runtime complexity.
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 1)
            {
                if (nums[0] >= target) return 0; else return 1;
            }

            int index = nums.Length / 2;
            int inc = index / 2;

            while (true)
            {
                if (index >= nums.Length || index==0) return index;
                if(nums[index] >= target && nums[index-1]<=target) return index;
                if (nums[index] > target)
                {
                    index -= index>0? inc == 0 ? 1 : inc:0;
                    inc /= 2;
                }
                else
                {
                    index += inc == 0 ? 1 : inc;
                    inc /= 2;
                }
            }
            

        }
    }
}
