using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //341. Flatten Nested List Iterator
    //    You are given a nested list of integers nestedList.Each element is either an integer or a list whose elements may also be integers or other lists.Implement an iterator to flatten it.

    //    Implement the NestedIterator class:

    //    NestedIterator(List < NestedInteger > nestedList) Initializes the iterator with the nested list nestedList.
    //    int next() Returns the next integer in the nested list.
    //    boolean hasNext() Returns true if there are still some integers in the nested list and false otherwise.
    //    Your code will be tested with the following pseudocode:

    //initialize iterator with nestedList
    //res = []
    //while iterator.hasNext()
    //    append iterator.next() to the end of res
    //return res
    //If res matches the expected flattened list, then your code will be judged as correct.
    internal class _341_
    {
        /**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
        private List<int> flattened;
        private int index;
        public _341_(IList<NestedInteger> nestedList)
        {
            flattened = new List<int>();
            index = 0;
            flattened = Flatten(nestedList);
        }
        private List<int> Flatten(IList<NestedInteger> nested)
        {
            List<int> result = new List<int>();
            foreach (var ni in nested)
            {
                if (ni.IsInteger())
                {
                    result.Add(ni.GetInteger());
                }
                else
                {
                    result.AddRange(Flatten(ni.GetList()));
                }
            }
            return result;
        }
        public bool HasNext()
        {
            return index < flattened.Count;
        }

        public int Next()
        {
            return flattened[index++];
            
        }
    }
}
