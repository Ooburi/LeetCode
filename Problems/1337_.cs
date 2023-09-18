using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1337. The K Weakest Rows in a Matrix
    //    You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's(representing civilians).
    //    The soldiers are positioned in front of the civilians.That is, all the 1's will appear to the left of all the 0's in each row.

    //    A row i is weaker than a row j if one of the following is true:
    //    The number of soldiers in row i is less than the number of soldiers in row j.
    //    Both rows have the same number of soldiers and i < j.
    //    Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
    internal class _1337_
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            

            for(int i=0;i<mat.Length; i++)
            {
                mat[i][0] = CountSoldiers(mat[i]);
            }
            
            return mat.Select((row,i) => new {Strength = row[0],Index = i}).
                OrderBy(x=>x.Strength).
                Take(k).
                Select(x=>x.Index).
                ToArray();

        }
    //    Sort(mat, k);


    //}
    //static void Sort(int[][] arr, int k)
    //{
    //    if (k >= arr.Length) return;
    //    int left = 0;
    //    int right = arr.Length;
    //    int middle = arr[k][0];

    //    while (left <= k && right > k)
    //    {
    //        if (arr[left][0] >= middle)
    //        {
    //            var temp = middle;
    //            middle = arr[left][0];
    //            arr[left][0] = temp;
    //        }
    //        else
    //            if ()
    //        }
    //}

    static int CountSoldiers(int[] row)
        {
            if (row[0] == 0) return 0;

            int left = 0, right = row.Length;
            int index = right / 2;
            
            while (right-left>1)
            {
                if (row[index] == 1)
                {
                    left = index;
                } else
                {
                    right = index;
                }
                index = left + (right - left) / 2;
            }
            return index+1;
        }
    }
}
