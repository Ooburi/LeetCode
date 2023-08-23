using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //Given a roman numeral, convert it to an integer.
    //Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
        //    Symbol Value
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        //For example, 2 is written as II in Roman numeral, just two ones added together. 12 is written as XII, which is simply X + II.
        //The number 27 is written as XXVII, which is XX + V + II.

        //Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII.
        //Instead, the number four is written as IV.Because the one is before the five we subtract it making four.
        //The same principle applies to the number nine, which is written as IX.

        //There are six instances where subtraction is used:
        //I can be placed before V (5) and X(10) to make 4 and 9. 
        //X can be placed before L(50) and C(100) to make 40 and 90. 
        //C can be placed before D(500) and M(1000) to make 400 and 900.
    internal class _13_RomanToInteger
    {
        public int RomanToInt(string s)
        {
            List<int> numbers = new List<int>();

            while (s != "")
            {
                if (s.Contains("CM"))
                {
                    int index = s.IndexOf("CM");
                    numbers.Add(900);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("CD"))
                {
                    int index = s.IndexOf("CD");
                    numbers.Add(400);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("XC"))
                {
                    int index = s.IndexOf("XC");
                    numbers.Add(90);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("XL"))
                {
                    int index = s.IndexOf("XL");
                    numbers.Add(40);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("IX"))
                {
                    int index = s.IndexOf("IX");
                    numbers.Add(9);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("IV"))
                {
                    int index = s.IndexOf("IV");
                    numbers.Add(4);
                    s = s.Remove(index, 2);
                    continue;
                }
                if (s.Contains("M"))
                {
                    int index = s.IndexOf("M");
                    numbers.Add(1000);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("D"))
                {
                    int index = s.IndexOf("D");
                    numbers.Add(500);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("C"))
                {
                    int index = s.IndexOf("C");
                    numbers.Add(100);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("L"))
                {
                    int index = s.IndexOf("L");
                    numbers.Add(50);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("X"))
                {
                    int index = s.IndexOf("X");
                    numbers.Add(10);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("V"))
                {
                    int index = s.IndexOf("V");
                    numbers.Add(5);
                    s = s.Remove(index, 1);
                    continue;
                }
                if (s.Contains("I"))
                {
                    int index = s.IndexOf("I");
                    numbers.Add(1);
                    s = s.Remove(index, 1);
                    continue;
                }
            }

            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            return sum;
        }
    }
}
