using Solutions.Problems;
using static Solutions.Problems._138_CopyListWithRandomPointer;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new(1);
            head.next = new(2);
            head.next.next = new(3);
            head.next.next.next = new(4);
            head.next.next.next.next = new(5);

            
            //Console.WriteLine(_92_ReverseLinkedListII.ReverseBetween(head,2,4)); 
            //Console.WriteLine(_92_ReverseLinkedListII.ReverseBetween(head.next.next.next.next, 1, 1));
            Console.WriteLine(_92_ReverseLinkedListII.ReverseBetween(head.next.next.next, 1, 2));
            Console.ReadLine();
        }
    }
}