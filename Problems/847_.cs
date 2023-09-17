﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    internal class _847_
    {
        //847. Shortest Path Visiting All Nodes

        //You have an undirected, connected graph of n nodes labeled from 0 to n - 1.
        //You are given an array graph where graph[i] is a list of all the nodes connected with node i by an edge.

        //Return the length of the shortest path that visits every node.
        //You may start and stop at any node, you may revisit nodes multiple times, and you may reuse edges.
        public int ShortestPathLength(int[][] graph)
        {
            int n = graph.Length;
            int allVisited = (1 << n) - 1;
            Queue<int[]> queue = new Queue<int[]>();
            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(new int[] { 1 << i, i, 0 });
                visited.Add((1 << i) * 16 + i);
            }

            while (queue.Count > 0)
            {
                int[] cur = queue.Dequeue();

                if (cur[0] == allVisited)
                {
                    return cur[2];
                }

                foreach (int neighbor in graph[cur[1]])
                {
                    int newMask = cur[0] | (1 << neighbor);
                    int hashValue = newMask * 16 + neighbor;

                    if (!visited.Contains(hashValue))
                    {
                        visited.Add(hashValue);
                        queue.Enqueue(new int[] { newMask, neighbor, cur[2] + 1 });
                    }
                }
            }

            return -1;
        }
    }
}
