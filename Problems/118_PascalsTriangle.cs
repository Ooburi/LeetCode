using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        //119. Pascal's Triangle II

        //Given an integer rowIndex, return the rowIndexth (0-indexed) row of the Pascal's triangle.

        //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:
        public static IList<int> GetRow(int rowIndex)
        {
            //CAST OVERFLOW

            //IList<int> list = new List<int> { 1 };
            //for(int i = 1; i < rowIndex; i++)
            //{
            //    list.Add((int)getBCoef(rowIndex, i));
            //}
            //if(rowIndex > 1)
            //list.Add(1);
            //return list;
            Dictionary<(int, int), int> dictionary = new();

            IList<int> list = new List<int>();
            for(int i=0; i <= rowIndex/2; i++)
            {
                list.Add(GetN(rowIndex,i,dictionary));
            }
            if (rowIndex % 2 == 0)
            {
                for(int i = list.Count - 2; i >= 0; i--)
                {
                    list.Add(list[i]);
                }
            } else
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    list.Add(list[i]);
                }
            }
            return list;
        }

        public static int GetN(int rowIndex, int k, Dictionary<(int, int), int> d)
        {
            if (rowIndex == 0 || k == 0 || k==rowIndex) return 1;
            if(d.ContainsKey((rowIndex,k))) return d[(rowIndex,k)]; else
            {
                d.Add((rowIndex, k), GetN(rowIndex - 1, k, d) + GetN(rowIndex - 1, k - 1, d));
            }
                return GetN(rowIndex-1,k,d) + GetN(rowIndex-1, k-1,d);
        }
        //public static BigInteger getBCoef(int rowIndex, int k)
        //{
        //    BigInteger numerator = 1;
        //    for(int i = k+1; i<rowIndex+1; i++)
        //    {
        //        numerator *= i;
        //    }
        //    BigInteger denominator = 1;
        //    for(int i=1;i<=rowIndex-k; i++)
        //    {
        //        denominator *= i;
        //    }
        //    return numerator / denominator;
        //}
    }
}
