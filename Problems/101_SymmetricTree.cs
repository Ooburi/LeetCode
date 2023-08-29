using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //101. Symmetric Tree
    //Given the root of a binary tree, check whether it is a mirror of itself(i.e., symmetric around its center).
    internal class _101_SymmetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            if(root.left==null && root.right!=null || root.left!=null && root.left==null || root.left?.val != root.right?.val)
                return false;

            if (root.left == null && root.right == null) return true;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root.left);

            StringBuilder sbLeftBranch = new StringBuilder("");
            StringBuilder sbRightBranch = new StringBuilder("");


            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                sbLeftBranch.Append(node.val);

                if(node.left!=null && node.right==null)
                    sbLeftBranch.Append("L");
                else if(node.left == null && node.right != null)
                    sbLeftBranch.Append("R");

                if (node.right != null) stack.Push(node.right);
                if (node.left!=null) stack.Push(node.left);

            }

            stack.Push(root.right);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                sbRightBranch.Append(node.val);

                if (node.left != null && node.right == null)
                    sbRightBranch.Append("R");
                else if (node.left == null && node.right != null)
                    sbRightBranch.Append("L");
                if (node.left != null) stack.Push(node.left);
                if (node.right != null) stack.Push(node.right);

            }

            return String.Compare(sbLeftBranch.ToString(),sbRightBranch.ToString())==0;
        }
    }
}
