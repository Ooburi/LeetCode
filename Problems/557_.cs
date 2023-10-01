using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //557. Reverse Words in a String III
    //Given a string s, reverse the order of characters in each word
    //within a sentence while still preserving whitespace and initial word order.
    internal class _557_
    {
        public string ReverseWords(string s)
        {
            string[] ar = s.Split(' ');

            StringBuilder sb = new();

            foreach(string st in ar)
            {
                for(int i = st.Length-1; i >=0; i--)
                {
                    sb.Append(st[i]);
                }
                sb.Append(' ');
            }
            sb.Remove(sb.Length - 1,1);
            return sb.ToString();
        }
    }
}
