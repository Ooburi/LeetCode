using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1356. Sort Integers by The Number of 1 Bits
    //You are given an integer array arr.Sort the integers in the array in
    //ascending order by the number of 1's in their binary representation
    //and in case of two or more integers have the same number of 1's you have to sort them in ascending order.

    //Return the array after sorting it.
    internal class _1356_
    {
        public int[] SortByBits(int[] arr)
        {
            Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();

            foreach (int i in arr)
            {
                int count = Convert.ToString(i, 2).Count(c => c == '1');
                if (!D.ContainsKey(count))
                {
                    D[count] = new List<int>();
                }
                D[count].Add(i);
            }

            List<int> result = new List<int>();
            foreach (var key in D.Keys.OrderBy(k => k))
            {
                D[key].Sort();
                result.AddRange(D[key]);
            }

            return result.ToArray();
        }
    }
}
