using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //2251. Number of Flowers in Full Bloom
    //You are given a 0-indexed 2D integer array flowers, where flowers[i] = [starti, endi]
    //means the ith flower will be in full bloom from starti to endi(inclusive).
    //You are also given a 0-indexed integer array people of size n, where
    //people[i] is the time that the ith person will arrive to see the flowers.

    //Return an integer array answer of size n, where answer[i] is the number
    //of flowers that are in full bloom when the ith person arrives.
    internal class _2251_
    {
        public int[] FullBloomFlowers(int[][] flowers, int[] people)
        {
            int n = people.Length;
            int[] result = new int[n];
            Dictionary<int, int> events = new();

            foreach (int[] flower in flowers)
            {
                events.TryAdd(flower[0], 0);
                events[flower[0]] += 1;

                events.TryAdd(flower[1] + 1, 0);
                events[flower[1] + 1] -= 1;
            }

            var keys = events.Keys.ToList();
            int sum = 0;
            keys.Sort();
            foreach (int key in keys)
            {
                events[key] += sum;
                sum = events[key];
            }

            for (int i = 0; i < n; ++i)
            {
                int person = people[i];

                int left = 0;
                int right = keys.Count() - 1;
                int recent = -1;

                while (left <= right)
                {
                    int temp = left + (right - left) / 2;

                    if (keys[temp] <= person)
                    {
                        recent = keys[temp];
                        left = temp + 1;
                    }
                    else
                    {
                        right = temp - 1;
                    }
                }

                result[i] = recent == -1 ? 0 : events[recent];
            }

            return result;
        }
    }
}
