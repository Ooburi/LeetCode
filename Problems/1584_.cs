using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1584. Min Cost to Connect All Points
    //You are given an array points representing integer coordinates of some points on a 2D-plane, where points[i] = [xi, yi].

    //The cost of connecting two points[xi, yi] and[xj, yj]
    //is the manhattan distance between them: |xi - xj| + |yi - yj|,
    //where |val| denotes the absolute value of val.

    //Return the minimum cost to make all points connected.
    //All points are connected if there is exactly one simple path between any two points.
    internal class _1584_
    {
        public static int MinCostConnectPoints(int[][] points)
        {
            //int count = 0;
            //Dictionary<int, int> connections = new Dictionary<int, int>();

            //for (int i = 0; i < points.Length; i++)
            //{
            //    int min = int.MaxValue;
            //    int index = -1;

            //    for (int j = 0; j < points.Length; j++)
            //    {
            //        if (i != j)
            //        {
            //            int distance = (int)Math.Abs(points[i][0] - points[j][0]) + (int)Math.Abs(points[i][1] - points[j][1]);
            //            if (min >= distance)
            //            {
            //                min = distance;
            //                index = j;
            //            }
            //        }
            //    }
            //    if (min != int.MaxValue && (!connections.ContainsKey(index) || connections[index] != i))
            //    {
            //        count += min;
            //        connections[i] = index;
            //    }
            //}
            //return count;


            //[[2,-3],[-17,-8],[13,8],[-17,-15]]
            //53
            int count = 0;
            Dictionary<int, int> connections = new Dictionary<int, int>();

            for (int i = 0; i < points.Length; i++)
            {
                int min = int.MaxValue;
                int index = -1;
                for (int j = 0; j < points.Length; j++)
                {
                    if (i != j)
                    {
                        int distance = (int)Math.Abs(points[i][0] - points[j][0]) + (int)Math.Abs(points[i][1] - points[j][1]);
                        if (min >= distance)
                        {
                            min = distance;
                            index = j;
                        }
                    }
                }
                if ((!connections.ContainsKey(i) || connections[i] != index)&&(!connections.ContainsKey(index) || connections[index] != i))
                {
                    count += min;
                    connections[i] = index;
                }
            }

            return count;


            //// Define a helper function 'Find' to find the representative (root) of a set using path compression.
            //int Find(int[] parent, int x)
            //{
            //    if (parent[x] == x)
            //        return x;
            //    parent[x] = Find(parent, parent[x]); // Path compression: Set the parent to the root.
            //    return parent[x];
            //}

            //// Define a helper function 'Union' to unite two sets by setting one's root as the parent of the other's root.
            //void Union(int[] parent, int x, int y)
            //{
            //    parent[Find(parent, x)] = Find(parent, y); // Set root of 'x' as parent of root of 'y'.
            //}

            //// Get the number of points in the input.
            //int n = points.Length;

            //// Create a list of edges 'edges' to store the edges between points along with their Manhattan distances.
            //List<Tuple<int, int, int>> edges = new List<Tuple<int, int, int>>();

            //// This loop comprehensively computes the distances between all pairs of points and stores them in 'edges'.
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        int cost = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);
            //        edges.Add(Tuple.Create(cost, i, j));
            //    }
            //}

            //// Sort the edges by their distances in ascending order.
            //edges.Sort((a, b) => a.Item1.CompareTo(b.Item1));

            //// Create an array 'parent' initialized such that each point is its own parent (initially isolated).
            //int[] parent = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    parent[i] = i;
            //}

            //// Initialize 'min_cost' to track the total minimum cost, and 'num_edges' to track the number of edges added to the MST.
            //int min_cost = 0;
            //int num_edges = 0;

            //// Iterate through the sorted edges.
            //foreach (var edge in edges)
            //{
            //    int cost = edge.Item1;
            //    int u = edge.Item2;
            //    int v = edge.Item3;

            //    // Check if adding this edge (connecting points 'u' and 'v') doesn't create a cycle in the minimum spanning tree.
            //    if (Find(parent, u) != Find(parent, v))
            //    {
            //        // If it doesn't create a cycle, unite the sets containing 'u' and 'v', and update 'min_cost'.
            //        Union(parent, u, v);
            //        min_cost += cost;
            //        num_edges++;

            //        // If we have added 'n - 1' edges (forming a spanning tree), exit the loop.
            //        if (num_edges == n - 1)
            //            break;
            //    }
            //}

            //// Return the minimum cost to connect all points (the minimum spanning tree cost).
            //return min_cost;
        }
    }
}
