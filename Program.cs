using Solutions.Problems;
using static Solutions.Problems._138_CopyListWithRandomPointer;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node nodeOne = new(1);
            Node nodeTwo = new(1);
            Node nodeThree = new(1);
            Node nodeFour = new(1);
            Node nodeFive = new(1);

            nodeOne.next = nodeTwo;
            nodeOne.random = null;

            nodeTwo.next = nodeThree;
            nodeTwo.random = nodeOne;

            nodeThree.next = nodeFour;
            nodeThree.random = nodeFive;

            nodeFour.next = nodeFive;
            nodeFour.random = nodeThree;

            nodeFive.next = null;
            nodeFive.random = nodeOne;

            _138_CopyListWithRandomPointer.CopyRandomList(nodeOne);
            //Console.WriteLine(_605_CanPlaceFlowers.CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 0, 1 }, 2)); //true
            Console.ReadLine();
        }
    }
}