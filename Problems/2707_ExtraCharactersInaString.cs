using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2707. Extra Characters in a String
    //You are given a 0-indexed string s and a dictionary of words dictionary.
    //You have to break s into one or more non-overlapping substrings such that each substring is present in dictionary.
    //There may be some extra characters in s which are not present in any of the substrings.

    //Return the minimum number of extra characters left over if you break up s optimally.
    internal class _2707_ExtraCharactersInaString
    {
        //"dwmodizxvvbosxxw"
        //["ox","lb","diz","gu","v","ksv","o","nuq","r","txhe","e","wmo","cehy","tskz","ds","kzbu"]
        public int MinExtraChar(string s, string[] dictionary)
        {
            //StringBuilder sb = new StringBuilder(s);
            //Array.Sort(dictionary, (x, y) => x.Length.CompareTo(y.Length));
            //foreach (string str in dictionary)
            //{
            //    int index = sb.ToString().IndexOf(str);
            //    if(index!=-1)
            //    {
            //        sb.Replace(str, "");
            //    }
            //}
            //return sb.Length;
            int maxVal = s.Length + 1;
            int[] dp = new int[s.Length + 1];
            Array.Fill(dp, maxVal);
            dp[0] = 0;

            HashSet<string> dictionarySet = new HashSet<string>(dictionary);

            for (int i = 1; i <= s.Length; ++i)
            {
                dp[i] = dp[i - 1] + 1;
                for (int l = 1; l <= i; ++l)
                {
                    if (dictionarySet.Contains(s.Substring(i - l, l)))
                    {
                        dp[i] = Math.Min(dp[i], dp[i - l]);
                    }
                }
            }
            return dp[s.Length];
        }
    }
}
