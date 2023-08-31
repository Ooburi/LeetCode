using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //144. Binary Tree Preorder Traversal
    //Given the root of a binary tree, return the preorder traversal of its nodes' values.
    internal class _144_BinaryTreePreorderTraversal
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> preorderTraversal = new List<int>();
            if(root==null) return preorderTraversal;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                var node = stack.Pop();
                preorderTraversal.Add(node.val);
                if(node.left!=null) stack.Push(node.left);
                if (node.right != null) stack.Push(node.right);
            }
            return preorderTraversal;
        }
    }
}
