using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //111. Minimum Depth of Binary Tree
    //Given a binary tree, find its minimum depth.

    //The minimum depth is the number of nodes along the shortest path from the root node down to the nearest leaf node.

    //Note: A leaf is a node with no children.
    internal class _111_MinimumDepthBinaryTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            Stack<(TreeNode node, int level) > stack = new Stack<(TreeNode node, int level)>();
            stack.Push((root, 1));
            int min = int.MaxValue;
            while (stack.Any())
            {
                var node = stack.Pop();
                if(node.level<min && node.node.left==null && node.node.right==null) min = node.level;
                if (node.node.left != null) stack.Push((node.node.left, node.level + 1));
                if (node.node.right != null) stack.Push((node.node.right, node.level + 1));
            }
            return min;
        }
    }
}
