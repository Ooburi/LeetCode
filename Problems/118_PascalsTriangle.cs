using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //118. Pascal's Triangle

    //    Given an integer numRows, return the first numRows of Pascal's triangle.
    //In Pascal's triangle, each number is the sum of the two numbers directly above
    internal class _118_PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> row = new List<int>();
                for(int j = 0; j < i+1; j++)
                {
                    if (j == 0 || j == i) row.Add(1);
                    else
                    {
                        row.Add(list.Last()[j - 1] + list.Last()[j]);
                    }
                }
                list.Add(row);
            }
            return list;
        }
    }
}
