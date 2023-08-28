using System;
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
            var i = --m + n--;
            while (n >= 0)
                nums1[i--] = m >= 0 && nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
        }
    }
}
