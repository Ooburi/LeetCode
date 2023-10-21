using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1425. Constrained Subsequence Sum
    //Given an integer array nums and an integer k, return the maximum sum of a non-empty
    //subsequence of that array such that for every two consecutive integers in the subsequence,
    //nums[i] and nums[j], where i<j, the condition j - i <= k is satisfied.

    //A subsequence of an array is obtained by deleting some number of elements
    //(can be zero) from the array, leaving the remaining elements in their original order.
    internal class _1425_
    {
        public int ConstrainedSubsetSum(int[] nums, int k)
        {
            var dq = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] += dq.Count > 0 ? nums[dq.First.Value] : 0;

                while (dq.Count > 0 && (i - dq.First.Value >= k || nums[i] >= nums[dq.Last.Value]))
                {
                    if (nums[i] >= nums[dq.Last.Value]) dq.RemoveLast();
                    else dq.RemoveFirst();
                }

                if (nums[i] > 0)
                {
                    dq.AddLast(i);
                }
            }
            return nums.Max();
        }
    }
}
