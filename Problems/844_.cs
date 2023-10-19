using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //844. Backspace String Compare
    //Given two strings s and t, return true if they are equal when both are typed into empty text editors. '#' means a backspace character.

    //Note that after backspacing an empty text, the text will continue empty.
    internal class _844_
    {
        public static bool BackspaceCompare(string s, string t)
        {
            int index = 0;
            while (s.Contains('#'))
            {
                index = s.IndexOf('#') - 1;
                s = index >= 0 ? s.Remove(index, 2) : s.Remove(index + 1, 1);
            }
            while (t.Contains('#'))
            {
                index = t.IndexOf('#') - 1;
                t = index >= 0 ? t.Remove(index, 2) : t.Remove(index + 1, 1);
            }
            return string.Compare(s, t) == 0;
        }
    }
}
