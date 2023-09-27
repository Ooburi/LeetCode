using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //880. Decoded String at Index
    //    You are given an encoded string s.To decode the string to a tape, the encoded string is read
    //    one character at a time and the following steps are taken:


    //    If the character read is a letter, that letter is written onto the tape.
    //If the character read is a digit d, the entire current tape is repeatedly written d - 1 more times in total.
    //    Given an integer k, return the kth letter (1-indexed) in the decoded string.
    internal class _880_
    {
        public string DecodeAtIndex(string s, int k)
        {
            long length = 0;
            int i = 0;

            while (length < k)
            {
                if (char.IsDigit(s[i]))
                {
                    length *= s[i] - '0';
                }
                else
                {
                    length++;
                }
                i++;
            }

            for (int j = i - 1; j >= 0; j--)
            {
                if (char.IsDigit(s[j]))
                {
                    length /= s[j] - '0';
                    k %= (int)length;
                }
                else
                {
                    if (k == 0 || k == length)
                    {
                        return s[j].ToString();
                    }
                    length--;
                }
            }

            return "";
        }
    }
}
