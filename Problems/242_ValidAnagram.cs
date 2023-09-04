using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //242. Valid Anagram
    //Given two strings s and t, return true if t is an anagram of s, and false otherwise.

    //An Anagram is a word or phrase formed by rearranging the letters of
    //a different word or phrase, typically using all the original letters exactly once.
    internal class _242_ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length!=t.Length) return false;
            char[] sArray = s.ToCharArray();
            char[] tArray = t.ToCharArray();
            Array.Sort(sArray);
            Array.Sort(tArray);
            for(int i = 0; i < sArray.Length; i++)
            {
                if (tArray[i] != sArray[i]) return false;
            }
            return true;
        }
    }
}
