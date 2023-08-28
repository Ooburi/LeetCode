using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    //94. Binary Tree Inorder Traversal
    //Given the root of a binary tree, return the inorder traversal of its nodes' values.
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
     public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
                 }
    }
    internal class _94_BinaryTreeInorderTraversal
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            //Queue<TreeNode> queue = new Queue<TreeNode>();
            //List<int> result = new();
            //if(root== null) return result;

            //queue.Enqueue(root);

            //while(queue.Count > 0)
            //{
            //    TreeNode node = queue.Dequeue();
            //    result.Add(node.val);

            //    if(node.left != null) queue.Enqueue(node.left);
            //    if(node.right != null) queue.Enqueue(node.right);
            //}
            //return result;

            //List<int> result = new();
            //if (root == null) return result;

            //Stack<TreeNode> stack = new Stack<TreeNode>();
            //stack.Push(root);

            //while(stack.Count > 0)
            //{
            //    TreeNode node = stack.Pop();
            //    result.Add(node.val);
            //    if(node.left != null) stack.Push(node.left);
            //    if(node.right != null) stack.Push(node.right);
            //}

            //return result;
            var list = new List<int>();
            InorderTraverseIteratively(root, list);
            return list;
        }
        private void InorderTraverseIteratively(TreeNode root, IList<int> list)
        {
            var current = root;
            var stack = new Stack<TreeNode>();

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                var top = stack.Pop();
                list.Add(top.val);
                current = top.right;
            }
        }
    }
}
