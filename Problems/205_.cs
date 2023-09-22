using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //205. Isomorphic Strings
    //Given two strings s and t, determine if they are isomorphic.

    //Two strings s and t are isomorphic if the characters in s can be replaced to get t.

    //All occurrences of a character must be replaced with another character while preserving
    //the order of characters.No two characters may map to the same character, but a character may map to itself.

    //Constraints:
    //    1 <= s.length <= 5 * 104
    //  t.length == s.length
    //  s and t consist of any valid ascii character.
    internal class _205_
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> dict = new();
            HashSet<char> set = new HashSet<char>();

            for(int i=0;i< s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (t[i] != dict[s[i]]) return false;
                }
                else
                {
                    if (set.Contains(t[i])) return false;
                    dict.Add(s[i], t[i]);
                    set.Add(t[i]);
                }
            }
            return true;
        }
    }
}
