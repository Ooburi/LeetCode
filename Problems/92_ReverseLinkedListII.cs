using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //92. Reverse Linked List II
    //Given the head of a singly linked list and two integers left and right
    //where left <= right, reverse the nodes of the list from position left to position right, and return the reversed list.
    internal class _92_ReverseLinkedListII
    {
        public static ListNode ReverseBetween(ListNode head, int left, int right)
        {
            //int count = 0;
            //ListNode headPointer = head;
            //ListNode previous = head;

            //while (head!=null)
            //{                
            //    if(count < right && count>left-1)
            //    {
            //        ListNode t = head;
            //        previous.next = head.next;
            //        head = head.next;
            //        head.next = t;

            //    } else
            //    {
            //        head = head.next;
            //        previous = head;
            //    }
            //    count++;
            //}
            //return headPointer;
            int count = 1;
            ListNode headPointer = head;

            ListNode first=head, last = head.next;
            Stack<ListNode> stack = new Stack<ListNode>();

            //while(head != null)
            //{
            //    if (count < left)
            //    {
            //        first = head;
            //    } else
            //    if(count <= right)
            //    {
            //        stack.Push(head);
            //        last = head.next;
            //    } 
            //    count++;
            //    head = head.next;
            //}

            //while (stack.Count>0)
            //{
            //    first.next = stack.Pop();                
            //    first = first.next;
            //}
            //first.next = last;
            //return headPointer;
            if (head == null || left == right) return head;

            ListNode dummyHead = new ListNode(0);
            dummyHead.next = head;
            ListNode previous = dummyHead;

            for (int i = 0; i < left - 1; i++)
            {
                previous = previous.next;
            }

            ListNode current = previous.next;

            for (int i = 0; i < right - left; i++)
            {
                ListNode nextNode = current.next;
                current.next = nextNode.next;
                nextNode.next = previous.next;
                previous.next = nextNode;
            }

            return dummyHead.next;
        }
    }
}
