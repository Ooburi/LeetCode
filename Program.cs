using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new(
                1,
                new(2, new(3), new(4)),
                new(2, new(4), new(3))
                );

            TreeNode root2 = new(
                1,
                new(2, null, new(3)),
                new(2, new(3), null)
                );
            var r = _108_ArrayToBinarySearchTree.SortedArrayToBST(new int[] { 0,1,2,3,4,5 });
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}