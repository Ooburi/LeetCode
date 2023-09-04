using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(_605_CanPlaceFlowers.CanPlaceFlowers(new int[] {1,0,0,0,1}, 2)); //false
            Console.WriteLine(_605_CanPlaceFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2)); //true
            Console.ReadLine();
        }
    }
}