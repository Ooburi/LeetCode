using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //1282. Group the People Given the Group Size They Belong To
    //There are n people that are split into some unknown number
    //of groups.Each person is labeled with a unique ID from 0 to n - 1.
    //You are given an integer array groupSizes, where groupSizes[i] is the size
    //of the group that person i is in. For example, if groupSizes[1] = 3, then person 1 must be in a group of size 3.
    //Return a list of groups such that each person i is in a group of size groupSizes[i].
    //Each person should appear in exactly one group, and every person must be in a group.If there are
    //multiple answers, return any of them.It is guaranteed that there will be at least one valid solution for the given input.
    internal class _1282_GroupThePeople
    {
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IList<IList<int>> people = new List<IList<int>>();
            Dictionary<int,IList<int>> peopleDictionary = new Dictionary<int,IList<int>>();

            for(int i=0;i<groupSizes.Length; i++)
            {
                if (!peopleDictionary.ContainsKey(groupSizes[i])) peopleDictionary[groupSizes[i]] = new List<int>();
                peopleDictionary[groupSizes[i]].Add(i);
            }

            
            foreach(int i in peopleDictionary.Keys)
            {
                while (peopleDictionary[i].Count > 0) //peopleDictionary[i] - elements of group N
                {
                    var list = new List<int>();
                    for (int j = 0; j < i; j++)
                    {
                        if (peopleDictionary[i].Count() > 0)
                        {
                            list.Add(peopleDictionary[i].Last());
                            peopleDictionary[i].RemoveAt(peopleDictionary[i].Count - 1);
                        }
                        else break;
                    }
                    people.Add(list);
                }
            }

            return people;
        }
    }
}
