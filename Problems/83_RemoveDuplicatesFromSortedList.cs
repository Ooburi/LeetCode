using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //83. Remove Duplicates from Sorted List

    //Given the head of a sorted linked list, delete all duplicates such that each element appears only once.
    //Return the linked list sorted as well.
    internal class _83_RemoveDuplicatesFromSortedList
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            
            ListNode temp = new(-101);
            ListNode dummyHead = new(0,temp);

            while (head != null)
            {
                if(head?.val == temp?.val)
                {
                    head = head.next;
                    continue;
                }
                temp.next  = new(head?.val ?? 0);
                temp = temp.next;
            }
            return dummyHead.next;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
