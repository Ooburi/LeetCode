using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //135. Candy
    //There are n children standing in a line.Each child is assigned a rating value given in the integer array ratings.

    //You are giving candies to these children subjected to the following requirements:

    //Each child must have at least one candy.
    //Children with a higher rating get more candies than their neighbors.
    //Return the minimum number of candies you need to have to distribute the candies to the children.
    internal class _135_Candy
    {
        public int Candy(int[] ratings)
        {
            int count = 1;
            int up = 0, down = 0, peak = 0;

            for (int i = 0; i < ratings.Length - 1; i++)
            {
                if (ratings[i] < ratings[i + 1])
                {
                    up++;
                    down = 0;
                    peak = up;
                    count += 1 + up;
                }
                else if (ratings[i] == ratings[i + 1])
                {
                    up = down = peak = 0;
                    count++;
                }
                else
                {
                    up = 0;
                    down++;
                    count += 1 + down;
                    if (peak >= down)
                    {
                        count--;
                    }
                }
            }
            return count;
        }
    }
}
