using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //58. Length of Last Word

    //    Given a string s consisting of words and spaces, return the length of the last word in the string.
    //A word is a maximal
    //substring
    // consisting of non-space characters only.
    internal class _58_LengthOfLastWord
    {
        public int LengthOfLastWord(string s)
        {
            bool wordStarted = false;
            int count = 0;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if(s[i] != ' ')
                {
                    wordStarted = true;
                    count++;
                } else
                {
                    if(wordStarted) return count;
                }
            }
            return count;
        }
    }
}
