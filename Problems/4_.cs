using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //4. Median of Two Sorted Arrays
    //Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

    //The overall run time complexity should be O(log (m+n)).
    internal class _4_
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double result = 0;

            int l = 0, r = 0;
            double middle = (nums1.Length + nums2.Length) / 2.0;

            for (int count = 0; count <= middle; count++)
            {
                int num = (l < nums1.Length && (r >= nums2.Length || nums1[l] < nums2[r])) ? nums1[l++] : nums2[r++];
                if (count >= middle - 1) result += num / (2 - (middle * 2 % 2));
            }

            return result;
        }
    }
}
