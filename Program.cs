using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = _118_PascalsTriangle.GetRow(33);
            string s = "A man, a plan, a canal: Panama";
            //Console.WriteLine(char.IsNumber(' '));
            Console.WriteLine(_125_ValidPalindrome.IsPalindrome(s));
            Console.ReadLine();
        }
    }
}