using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1647. Minimum Deletions to Make Character Frequencies Unique

    //A string s is called good if there are no two different characters in s that have the same frequency.
    //Given a string s, return the minimum number of characters you need to delete to make s good.
    //The frequency of a character in a string is the number of times it appears in the string.
    //For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.
    internal class _1647_
    {
        public static int MinDeletions(string s)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            int total = 0;
            HashSet<int> used = new HashSet<int>();

            foreach (char a in s)
            {
                if (count.ContainsKey(a)) count[a]++;
                else count[a] = 1;
            }

            foreach (int value in count.Values)
            {
                int v = value;
                while (v > 0 && used.Contains(v))
                {
                    v--;
                    total++;
                }
                used.Add(v);
            }

            return total;
        }
    }
}
