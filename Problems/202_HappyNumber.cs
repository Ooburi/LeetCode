using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //202. Happy Number

    //    Write an algorithm to determine if a number n is happy.
    //    A happy number is a number defined by the following process:

    //Starting with any positive integer, replace the number by the sum of the squares of its digits.
    //Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    //Those numbers for which this process ends in 1 are happy.
    //Return true if n is a happy number, and false if not.
    internal class _202_HappyNumber
    {
        public static bool IsHappy(int n)
        {
            HashSet<int> sums = new HashSet<int>();

            while (n!=1)
            {
                char[] chars = n.ToString().ToCharArray();
                int sum = 0;
                foreach(char c in chars)
                {
                    sum += (int)Math.Pow(Convert.ToInt32(c-48), 2);
                }
                n = sum;
                if (sums.Contains(n)) return false;
                sums.Add(n);
            }
            return true;
        }
        
    }
}
