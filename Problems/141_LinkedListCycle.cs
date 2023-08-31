using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //141. Linked List Cycle
    //    Given head, the head of a linked list, determine if the linked list has a cycle in it.
    //    There is a cycle in a linked list if there is some node in the list that can be reached
    //    again by continuously following the next pointer.Internally, pos is used to denote the
    //    index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
    //Return true if there is a cycle in the linked list.Otherwise, return false.
    internal class _141_LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;

            while (head != null)
            {
                if (head.val == Int32.MaxValue) return true;

                head.val = Int32.MaxValue;
                head = head.next;
            }

            return false;
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}
