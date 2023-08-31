using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    //125. Valid Palindrome
    //A phrase is a palindrome if, after converting all uppercase letters into lowercase
    //letters and removing all non-alphanumeric characters, it reads the same forward and backward.
    //Alphanumeric characters include letters and numbers.

    //Given a string s, return true if it is a palindrome, or false otherwise.
    internal class _125_ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            int start = 0;
            int end = s.Length-1;

            while(start < end)
            {
                if (char.IsLetterOrDigit(s[start]) && char.IsLetterOrDigit(s[end]))
                {
                    if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
                    else
                    {
                        start++;
                        end--;
                    }
                }
                else if (char.IsLetterOrDigit(s[start]))
                {
                    end--;
                }
                else start++;
            }
            return true;
        }
    }

}
