﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //88. Merge Sorted Array

    //    You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
    //    and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

    //Merge nums1 and nums2 into a single array sorted in non-decreasing order.

    //The final sorted array should not be returned by the function, but instead be stored inside the array nums1.
    //To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged,
    //and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
    internal class _88_MergeTwoSortedList
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = 0;
            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[index++];
            }

            for(int i =0; i<m; i++)
            {
                index = i;
                if (n>0 && nums1[i] >= nums2[0])
                {
                    break;
                }
            }

            for (int j = index>0?index:1; j < n+m; j++)
            {
                index = nums1[j];
                int i = j - 1;
                while (i >= 0 && index < nums1[i])
                {
                    nums1[i + 1] = nums1[i];
                    i--;
                }
                nums1[i + 1] = index;
            }
        }
    }
}
