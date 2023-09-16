using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1631. Path With Minimum Effort

    //You are a hiker preparing for an upcoming hike.
    //You are given heights, a 2D array of size rows x columns, where heights[row][col]
    //represents the height of cell(row, col). You are situated in the top-left cell, (0, 0),
    //and you hope to travel to the bottom-right cell, (rows - 1, columns - 1) (i.e., 0-indexed).
    //You can move up, down, left, or right, and you wish to find a route that requires the minimum effort.

    //A route's effort is the maximum absolute difference in heights between two consecutive cells of the route.
    //Return the minimum effort required to travel from the top-left cell to the bottom-right cell.
    internal class _1631_
    {
        public int MinimumEffortPath(int[][] heights)
        {
            int rows = heights.Length;
            int cols = heights[0].Length;

            int[][] efforts = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                efforts[i] = new int[cols];
                Array.Fill(efforts[i], int.MaxValue);
            }
            efforts[0][0] = 0;

            var minHeap = new SortedSet<(int effort, int x, int y)>();
            minHeap.Add((0, 0, 0));
            int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };

            while (minHeap.Count > 0)
            {
                var (effort, x, y) = minHeap.Min;
                minHeap.Remove(minHeap.Min);

                if (effort > efforts[x][y]) continue;
                if (x == rows - 1 && y == cols - 1) return effort;

                foreach (var dir in directions)
                {
                    int nx = x + dir[0], ny = y + dir[1];
                    if (nx >= 0 && nx < rows && ny >= 0 && ny < cols)
                    {
                        int new_effort = Math.Max(effort, Math.Abs(heights[x][y] - heights[nx][ny]));
                        if (new_effort < efforts[nx][ny])
                        {
                            efforts[nx][ny] = new_effort;
                            minHeap.Add((new_effort, nx, ny));
                        }
                    }
                }
            }
            return -1;
        }
    }
}
