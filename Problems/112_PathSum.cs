using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //112. Path Sum
    //Given the root of a binary tree and an integer targetSum,
    //return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.
    //A leaf is a node with no children.
    internal class _112_PathSum
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            int currentSum = root.val;

            if(currentSum == targetSum && root.left==null && root.right==null) return true;

            return (HasPathSum(root.left, targetSum - currentSum) || HasPathSum(root.right, targetSum - currentSum));


        }
    }
}
