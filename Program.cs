using Solutions.Problems;
using static Solutions.Problems._138_CopyListWithRandomPointer;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int j = 10;
            int i = 5;

            (i, j) = (j, i);
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}