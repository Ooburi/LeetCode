using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //171. Excel Sheet Column Number
    //Given a string columnTitle that represents the column title as appears in an Excel sheet,
    //return its corresponding column number.
    internal class _171_ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            int result = 1;

            for(int i = 0; i < columnTitle.Length-1; i++)
            {
                result += (int)Math.Pow(26, columnTitle.Length - i - 1) * (columnTitle[i] - 'A' + 1);
            }
            result += (columnTitle[columnTitle.Length - 1] - 'A');
            return result;
        }
    }
}
