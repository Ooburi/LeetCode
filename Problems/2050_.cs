using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    internal class _2050_
    {
        //2050. Parallel Courses III
//        You are given an integer n, which indicates that there are n courses labeled from 1 to n.You are also given a 2D integer array relations where relations[j] = [prevCoursej, nextCoursej] denotes that course prevCoursej has to be completed before course nextCoursej (prerequisite relationship). Furthermore, you are given a 0-indexed integer array time where time[i] denotes how many months it takes to complete the (i+1)th course.

//        You must find the minimum number of months needed to complete all the courses following these rules:


//        You may start taking a course at any time if the prerequisites are met.
//Any number of courses can be taken at the same time.
//        Return the minimum number of months needed to complete all the courses.


//        Note: The test cases are generated such that it is possible to complete every course (i.e., the graph is a directed acyclic graph).
        public int MinimumTime(int n, int[][] relations, int[] time)
        {
            List<List<int>> graph = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                graph.Add(new List<int>());
            }

            foreach (int[] relation in relations)
            {
                int prev = relation[0] - 1;
                int next = relation[1] - 1;
                graph[next].Add(prev);
            }

            int[] memo = new int[n];
            int overallMinTime = 0;

            for (int course = 0; course < n; course++)
            {
                overallMinTime = Math.Max(overallMinTime, CalculateTime(course, graph, time, memo));
            }

            return overallMinTime;
        }
        private int CalculateTime(int course, List<List<int>> graph, int[] time, int[] memo)
        {
            if (memo[course] != 0)
            {
                return memo[course];
            }

            int maxPrerequisiteTime = 0;
            foreach (int prereq in graph[course])
            {
                maxPrerequisiteTime = Math.Max(maxPrerequisiteTime, CalculateTime(prereq, graph, time, memo));
            }

            memo[course] = maxPrerequisiteTime + time[course];
            return memo[course];
        }
    }
}
