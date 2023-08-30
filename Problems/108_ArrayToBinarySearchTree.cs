using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    internal class _108_ArrayToBinarySearchTree
    {
        //108. Convert Sorted Array to Binary Search Tree

        //Given an integer array nums where the elements are sorted in ascending order, convert it to a
        //height-balanced
        // binary search tree.

        //Constraints:

        //1 <= nums.length <= 104
        //-104 <= nums[i] <= 104
        //nums is sorted in a strictly increasing order.

        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return Branch(nums,0,nums.Length-1);
        }

        public static TreeNode Branch(int[] nums, int start, int end)
        {
            if(start==end) 
                return new TreeNode(nums[end]);

            int mid = start + (end - start) / 2;
            return new TreeNode(nums[mid], mid==start?null:Branch(nums,start,mid-1), Branch(nums, mid+1,end));
        }
    }
}
