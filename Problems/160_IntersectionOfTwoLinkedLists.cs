using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    internal class _160_IntersectionOfTwoLinkedLists
    {
        //160. Intersection of Two Linked Lists
        //Given the heads of two singly linked-lists headA and headB, return the node at which the two lists intersect.
        //If the two linked lists have no intersection at all, return null.
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            while (headA != null)
            {
                visited.Add(headA);
                headA = headA.next;
            }
            while(headB != null)
            {
                if(visited.Contains(headB)) return headB;
                headB = headB.next;
            }
            return null;
        }
    }
}
