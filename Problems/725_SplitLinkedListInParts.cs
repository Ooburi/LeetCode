using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //725. Split Linked List in Parts
    //Given the head of a singly linked list and an integer k, split the linked list into k consecutive linked list parts.

    //The length of each part should be as equal as possible: no two parts should have a size differing by more than one.
    //This may lead to some parts being null.

    //The parts should be in the order of occurrence in the input list,
    //and parts occurring earlier should always have a size greater than or equal to parts occurring later.

    //Return an array of the k parts.
    internal class _725_SplitLinkedListInParts
    {
        public static ListNode[] SplitListToParts(ListNode head, int k)
        {
            ListNode[] list = new ListNode[k];
            ListNode[] listHeads = new ListNode[k];

            ListNode dummy = head;
            int count = 0;

            while (head != null)
            {
                count++;
                head = head.next;
            }

            int offset = count % k;
            int maxElements = count / k;
            int currentIndex = 0;

            head = dummy;
            count = 0;

            while (head != null)
            {
                if (currentIndex == k) currentIndex = 0;

                if (list[currentIndex] == null)
                {
                    list[currentIndex] = new(head.val);
                    listHeads[currentIndex] = list[currentIndex];
                }
                else
                {
                    list[currentIndex].next = new(head.val);
                    list[currentIndex] = list[currentIndex].next;
                }
                count++;
                if (count >= (offset > 0 ? maxElements + 1 : maxElements))
                {
                    if (count >= maxElements + 1)
                    {
                        offset--;
                    }
                    currentIndex++;
                    count = 0;
                }
                head = head.next;
            }

            return listHeads;
        }
    }
}
