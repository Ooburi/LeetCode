using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    //110. Balanced Binary Tree
    //    Given a binary tree, determine if it is 
    //height-balanced

    internal class _110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return Height(root) >= 0;
        }

        public int Height(TreeNode node)
        {

            if (node == null)
            {
                return 0;
            }
            int leftSubtreeHeight = Height(node.left);
            if (leftSubtreeHeight == -1) return -1;
            int rightSubtreeHeight = Height(node.right);
            if (rightSubtreeHeight == -1) return -1;
            if (Math.Abs(leftSubtreeHeight - rightSubtreeHeight) > 1)
            {
                return -1;
            }
            return (Math.Max(leftSubtreeHeight, rightSubtreeHeight) + 1);
        }
    }
}
