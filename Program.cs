using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new[] { 3,2,2,3 };

            Console.WriteLine(_27_RemoveElement.RemoveElement(ar,3));
            Console.ReadLine();
        }
    }
}