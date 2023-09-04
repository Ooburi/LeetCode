using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //605. Can Place Flowers
    //   You have a long flowerbed in which some of the plots are planted, and some are not.However,
    //   flowers cannot be planted in adjacent plots.

    //Given an integer array flowerbed containing 0's and 1's,
    //where 0 means empty and 1 means not empty, and an integer n, return true if n new flowers can be planted
    //in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.
    internal class _605_CanPlaceFlowers
    {
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int x = 0;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0 && ((i + 1 == flowerbed.Length) || flowerbed[i + 1] == 0) && (i - 1 < 0 || flowerbed[i - 1] == 0))
                {
                    x++;
                    flowerbed[i] = 1;
                }
            }
            return x >= n;
        }
    }
}
