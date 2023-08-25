using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //14. Longest Common Prefix
    //Write a function to find the longest common prefix string amongst an array of strings.
    //If there is no common prefix, return an empty string "".

    //Example 1:
    //Input: strs = ["flower", "flow", "flight"]
    //Output: "fl"
    internal class _14_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int min = 200;
            foreach (string str in strs)
            {
                if(str.Length <= min) min = str.Length;
            }
            StringBuilder sb = new("");

            for(int i = 0; i < min; i++)
            {
                char c = strs[0][i];

                foreach (string str in strs)
                {
                    if (str[i] != c) return sb.ToString();
                }
                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
