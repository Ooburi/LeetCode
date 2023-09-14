using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //332. Reconstruct Itinerary
    //You are given a list of airline tickets where tickets[i] = [fromi, toi]
    //represent the departure and the arrival airports of one flight.
    //Reconstruct the itinerary in order and return it.

    //All of the tickets belong to a man who departs from "JFK", thus,
    //the itinerary must begin with "JFK". If there are multiple valid itineraries,
    //you should return the itinerary that has the smallest lexical order when read as a single string.

    //For example, the itinerary["JFK", "LGA"] has a smaller lexical order than["JFK", "LGB"].
    //You may assume all tickets form at least one valid itinerary.You must use all the tickets once and only once.

    //Constraints:

    //1 <= tickets.length <= 300
    //tickets[i].length == 2
    //fromi.length == 3
    //toi.length == 3
    //fromi and toi consist of uppercase English letters.
    //fromi != toi
    internal class _332_ReconstructItinerary
    {
        public IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            var graph = new Dictionary<string, List<string>>();

            foreach (var ticket in tickets)
            {
                if (!graph.ContainsKey(ticket[0]))
                {
                    graph[ticket[0]] = new List<string>();
                }
                graph[ticket[0]].Add(ticket[1]);
            }
            foreach (var destinations in graph.Values)
            {
                destinations.Sort((a, b) => b.CompareTo(a));
            }
            var itinerary = new List<string>();

            void DFS(string airport)
            {
                while (graph.ContainsKey(airport) && graph[airport].Count > 0)
                {
                    var next = graph[airport][^1];
                    graph[airport].RemoveAt(graph[airport].Count - 1);
                    DFS(next);
                }
                itinerary.Add(airport);
            }

            DFS("JFK");
            itinerary.Reverse();

            return itinerary;
        }
        
    }
}
