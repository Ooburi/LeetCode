using Solutions.Problems;

namespace Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(_171_ExcelSheetColumnNumber.TitleToNumber("AB")); //28
            Console.WriteLine(_171_ExcelSheetColumnNumber.TitleToNumber("FXSHRXW")); //2147483647
            Console.ReadLine();
        }
    }
}