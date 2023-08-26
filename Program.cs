using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new[] { 1,3,5,6 };
            int[] ar2 = new[] { 1 };

            Console.WriteLine(_35_SearchInsertPosition.SearchInsert(ar2, 2)); //1
            Console.WriteLine(_35_SearchInsertPosition.SearchInsert(ar,0)); 
            Console.WriteLine(_35_SearchInsertPosition.SearchInsert(ar, 2));
            Console.WriteLine(_35_SearchInsertPosition.SearchInsert(ar, 7));
            Console.ReadLine();
        }
    }
}