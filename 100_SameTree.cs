using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    //100. Same Tree

    //    Given the roots of two binary trees p and q, write a function to check if they are the same or not.

    //Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
    internal class _100_SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p?.val != q?.val || (q==null && p!=null) || (q!=null && p==null)) return false;
            if (p == null && q == null) return true;

            if(!IsSameTree(p.left, q.left)) return false;
            if (!IsSameTree(p.right, q.right)) return false ;
            return true;
        }
    }
      
}
