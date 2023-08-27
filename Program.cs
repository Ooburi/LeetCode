using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new[] { 1,2,3,0,0,0 };
            int[] ar2 = new[] { 2,5,6 };

            int[] ar3 = new[] { 1 };
            int[] ar4 = Array.Empty<int>();

            _88_MergeTwoSortedList.Merge(ar, 3, ar2, 3);
            _88_MergeTwoSortedList.Merge(ar3, 1, ar4, 0);

            foreach (int i in ar)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            foreach (int i in ar3)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}