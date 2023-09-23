using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //222. Count Complete Tree Nodes
    //Given the root of a complete binary tree, return the number of the nodes in the tree.

    //According to Wikipedia, every level, except possibly the last, is completely filled in a complete binary tree, and all nodes in the last level are as far left as possible.It can have between 1 and 2h nodes inclusive at the last level h.


    //Design an algorithm that runs in less than O(n) time complexity.
    internal class _222_
    {
        
        public static int CountNodes(TreeNode root)
        {
            if (root == null) return 0;
            int lh = leftHeight(root.left);
            int rh = rightHeight(root.right);

            if (rh == lh)
            {
                return (int)Math.Pow(2, lh);
            }
            else
            {
                return 1+CountNodes(root.left) + CountNodes(root.right);
            }

            int leftHeight(TreeNode node)
            {
                if (node == null) return 0;
                int h = 1;
                while(node != null)
                {
                    node = node.left;
                    if (node != null) h++;
                }
                return h;
            }
            int rightHeight(TreeNode node)
            {
                if (node == null) return 0;
                int h = 1;
                while (node != null)
                {
                    node = node.right;
                    if(node!=null)h++;
                }
                return h;
            }

        }
    }
}
