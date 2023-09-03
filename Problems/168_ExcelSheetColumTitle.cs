using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //168. Excel Sheet Column Title
    //Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.
    internal class _168_ExcelSheetColumTitle
    {
        

        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder("");
            while (columnNumber > 0)
            {
                columnNumber--;
                char c = (char)('A' + columnNumber % 26);
                columnNumber /= 26;
                sb.Insert(0, c);
            }
            return sb.ToString();
        }
    }
}
