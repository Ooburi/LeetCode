using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //34. Find First and Last Position of Element in Sorted Array
    //Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

    //If target is not found in the array, return [-1, -1].


    //You must write an algorithm with O(log n) runtime complexity.
    internal class _34_
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int i = -1, j = -1;
            if (nums.Length == 0) 
                return new int[] { i, j };

            int left = 0, right = nums.Length - 1;
            int index = 0;

            while (left<right)
            {
                index = (right - left)/2+left;
                if (nums[index] == target) break;
                if(nums[index] < target) left = index+1;
                else right = index;

                if (right == left) index = left;
            }

            if (nums[index]!=target) 
                return new int[] {i,j};

            i = index;
            j = index;
            while (j+1<nums.Length && nums[j + 1] == target) j++;
            while (i-1>=0 && nums[i - 1] == target) i--;

            return new int[] { i, j };
        }
    }
}
