using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2433. Find The Original Array of Prefix Xor
    //    You are given an integer array pref of size n.Find and return the array arr of size n that satisfies:


    //    pref[i] = arr[0] ^ arr[1] ^ ... ^ arr[i].
    //Note that ^ denotes the bitwise-xor operation.


    //    It can be proven that the answer is unique.
    internal class _2433_
    {
        public int[] FindArray(int[] pref)
        {
            int[] array = new int[pref.Length];
            array[0] = pref[0];
            for(int i = 1; i < pref.Length; i++)
            {
                array[i] = pref[i] ^ pref[i-1];
            }
            return array;
        }
    }
}
