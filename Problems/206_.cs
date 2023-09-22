using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //206. Reverse Linked List
    //Given the head of a singly linked list, reverse the list, and return the reversed list.
    internal class _206_
    {
        public ListNode ReverseList(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            while(head != null)
            {
                stack.Push(head);
                head = head.next;
            }
            ListNode newHead = null;
            while (stack.Any())
            {
                if(newHead == null)
                {
                    newHead = new(stack.Pop().val);
                    head = newHead;
                }
                else
                {
                    newHead.next = new(stack.Pop().val);
                    newHead = newHead.next;
                }                
            }
            return head;
        }
    }
}
