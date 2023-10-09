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
            Console.WriteLine(_34_.SearchRange(new int[] { 1,4 },4));
            Console.ReadLine();
        }
    }
}