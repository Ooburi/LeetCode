using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1458. Max Dot Product of Two Subsequences
    //Given two arrays nums1 and nums2.

    //Return the maximum dot product between non-empty subsequences of nums1 and nums2 with the same length.


    //A subsequence of a array is a new array which is formed from the original array by deleting
    //some(can be none) of the characters without disturbing the relative positions of the
    //remaining characters. (ie, [2,3,5] is a subsequence of[1, 2, 3, 4, 5] while [1,5,3] is not).
    internal class _1458_
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            //int m = nums1.Length, n = nums2.Length;
            //int[] current = new int[n + 1], previous = new int[n + 1];
            //Array.Fill(current, int.MinValue);
            //Array.Fill(previous, int.MinValue);

            //for (int i = 1; i <= m; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        int curr_product = nums1[i - 1] * nums2[j - 1];
            //        current[j] = Math.Max(Math.Max(Math.Max(curr_product, previous[j]), current[j - 1]), curr_product + Math.Max(0, previous[j - 1]));
            //    }
            //    (current, previous) = (previous, current);
            //}
            //return previous[n];
            int[] current = new int[nums2.Length+1];
            int[] prev = new int[nums2.Length+1];
            Array.Fill(current, int.MinValue);
            Array.Fill(prev, int.MinValue);

            for(int i=1; i<=nums1.Length; i++)
            {
                for(int j=1; j<=nums2.Length; j++)
                {
                    int product = nums1[i-1]*nums2[j-1];
                    // int prevPr = Math.Max(0, prev[j - 1]);
                    //int maxPr = Math.Max(product, prev[j]);
                    //int max = Math.Max(maxPr, current[j - 1]);
                    //Math.Max(max, product + prevPr);
                    current[j] = Math.Max(Math.Max(Math.Max(product, prev[j]), current[j - 1]), product + Math.Max(0, prev[j - 1]));
                }
                (current, prev) = (prev, current);
            }
            return prev[nums2.Length];
        }
    }
}
