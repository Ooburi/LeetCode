using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //203. Remove Linked List Elements
    //Given the head of a linked list and an integer val,
    //remove all the nodes of the linked list that has Node.val == val, and return the new head.
    internal class _203_
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode newHead = null;
            ListNode dummy = null;
            
            while (head != null)
            {
                if (newHead == null)
                {
                    if (head.val != val)
                    {
                        newHead = new(head.val);
                        dummy = newHead;
                    }
                } else
                {
                    if (head.val != val)
                    {
                        newHead.next = new(head.val);
                        newHead = newHead.next;
                    }
                }

                head = head.next;
            }

            return dummy;
        }
    }
}
