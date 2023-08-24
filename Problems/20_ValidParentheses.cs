using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //20. Valid Parentheses

    //    Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

    //An input string is valid if:

    //Open brackets must be closed by the same type of brackets.
    //Open brackets must be closed in the correct order.
    //Every close bracket has a corresponding open bracket of the same type.
    internal class _20_ValidParentheses
    {
        public static bool IsValid(string s)
        {
            Dictionary<char, char> type = new Dictionary<char, char>()
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}' }
            };
            Dictionary<char, char> typeInverted = new Dictionary<char, char>()
            {
                {')', '('},
                {']', '['},
                {'}', '{' }
            };

            Stack<char> opened = new Stack<char>();
            char popped;

            for (int i = 0; i < s.Length; i++)
            {
                if (type.ContainsKey(s[i]))
                {
                    opened.Push(s[i]);
                } else
                {
                    popped = '-';
                    opened.TryPeek(out popped);
                    if (typeInverted.GetValueOrDefault(s[i]) == popped)
                    {              
                        if (!opened.TryPop(out popped)) return false;
                    } else
                    {
                        return false;
                    }
                }
            }

            return !opened.TryPop(out popped);
        }
        
        
    }
}
