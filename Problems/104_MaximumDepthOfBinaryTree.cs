using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //104. Maximum Depth of Binary Tree

    //    Given the root of a binary tree, return its maximum depth.

    //A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
    internal class _104_MaximumDepthOfBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            int max = 0;
            if (root == null) return 0;
            Stack<(TreeNode node,int level)> stack = new Stack<(TreeNode, int level)>();
            stack.Push((root, 1));

            while (stack.Any())
            {
                var element = stack.Pop();
                if(element.level>max) max= element.level;
                if(element.node.left!=null)
                    stack.Push((element.node.left,element.level+1));
                if (element.node.right != null)
                    stack.Push((element.node.right, element.level + 1));
            }
            return max;
        }
    }
}
