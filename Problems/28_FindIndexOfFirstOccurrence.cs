using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //28. Find the Index of the First Occurrence in a String

    //Given two strings needle and haystack,
    //return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

    internal class _28_FindIndexOfFirstOccurrence
    {
        public int StrStr(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
        }
    }
}
