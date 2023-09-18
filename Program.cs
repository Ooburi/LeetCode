using Solutions.Problems;
using static Solutions.Problems._138_CopyListWithRandomPointer;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(_1337_.KWeakestRows(new int[4][]
            {
                new int[] { 1,1,1,0,0,0,0,0,0,0,0,0,0,0,0 }, //3
                new int[] { 1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,0 },//12
                new int[] { 0,0,0,0,0,0,0,0,0,0,0 },//0
                new int[] { 1,1,1,0,0,0 }//3
            },0
                ));
            Console.WriteLine(_1337_.KWeakestRows(new int[0][]
            {
            }, 0
                ));
            Console.ReadLine();
        }
    }
}