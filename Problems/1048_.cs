using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1048. Longest String Chain

    //    You are given an array of words where each word consists of lowercase English letters.

    //    wordA is a predecessor of wordB if and only if we can insert exactly one letter
    //    anywhere in wordA without changing the order of the other characters to make it equal to wordB.

    //    For example, "abc" is a predecessor of "abac", while "cba" is not a predecessor of "bcad".
    //A word chain is a sequence of words[word1, word2, ..., wordk] with k >= 1, where word1 is
    //a predecessor of word2, word2 is a predecessor of word3, and so on.A single word is trivially a word chain with k == 1.

    //Return the length of the longest possible word chain with words chosen from the given list of words.
    internal class _1048_
    {
        public static int LongestStrChain(string[] words)
        {

            Array.Sort(words, (a, b) => a.Length.CompareTo(b.Length));
            Dictionary<string, int> dp = new Dictionary<string, int>();
            int max_chain = 0;
            foreach (var word in words)
            {
                dp[word] = 1;
                for (int i = 0; i < word.Length; i++)
                {
                    string prev_word = word.Remove(i, 1);
                    if (dp.ContainsKey(prev_word))
                    {
                        dp[word] = dp[prev_word] + 1;
                    }
                }
                max_chain = Math.Max(max_chain, dp[word]);
            }
            return max_chain;


            //int wordChain = 0;
            //while(dict.Count > 0 || dict.Count>wordChain)
            //{
            //    List<int> keys = dict.Keys.ToList();

            //    foreach (var word in dict[keys[0]])
            //    {
            //        getMaxHeight(word, 1, keys);
            //    }

            //    dict.Remove(keys[0]);
            //}


            //void getMaxHeight(string word,int index, List<int> keys)
            //{
            //    if (index > wordChain) wordChain = index;
            //    if (keys.Count <= index) return;

            //    foreach (var w in dict[keys[index]])
            //    {
            //        if (ContainsWord(word,w))
            //        {

            //            getMaxHeight(w,index + 1, keys);
            //        }
            //        else continue;
            //    }
            //}

            //bool ContainsWord(string a, string b)
            //{
            //    int aPointer=0, bPointer = 0;
            //    int difference = 0;
            //    while(aPointer < a.Length && bPointer < b.Length)
            //    {
            //        if (a[aPointer] != b[bPointer])
            //        {
            //            difference++;
            //            bPointer++;
            //        }
            //        else
            //        {
            //            bPointer++;
            //            aPointer++;
            //        }
            //    }
            //    return difference < 2;
            //}
            //return wordChain;
        }
    }
}
