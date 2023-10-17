using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1361. Validate Binary Tree Nodes
    //You have n binary tree nodes numbered from 0 to n - 1 where node i has
    //two children leftChild[i] and rightChild[i], return true if and only if all the given nodes form exactly one valid binary tree.

    //If node i has no left child then leftChild[i] will equal -1, similarly for the right child.

    //Note that the nodes have no values and that we only use the node numbers in this problem.
    internal class _1361_
    {
        public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
            int[] inDegree = new int[n];

            for (int node = 0; node < n; node++)
            {
                int left = leftChild[node];
                int right = rightChild[node];
                if (left != -1)
                {
                    if (!graph.ContainsKey(node))
                    {
                        graph[node] = new List<int>();
                    }
                    graph[node].Add(left);
                    inDegree[left]++;
                }
                if (right != -1)
                {
                    if (!graph.ContainsKey(node))
                    {
                        graph[node] = new List<int>();
                    }
                    graph[node].Add(right);
                    inDegree[right]++;
                }
            }

            List<int> rootCandidates = new List<int>();
            for (int node = 0; node < n; node++)
            {
                if (inDegree[node] == 0)
                {
                    rootCandidates.Add(node);
                }
            }

            if (rootCandidates.Count != 1)
            {
                return false;
            }
            int root = rootCandidates[0];

            Queue<int> queue = new Queue<int>();
            HashSet<int> seen = new HashSet<int>();
            queue.Enqueue(root);
            seen.Add(root);

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();
                if (graph.ContainsKey(node))
                {
                    foreach (int child in graph[node])
                    {
                        if (seen.Contains(child))
                        {
                            return false;
                        }
                        seen.Add(child);
                        queue.Enqueue(child);
                    }
                }
            }

            return seen.Count == n;
        }
    }
}
