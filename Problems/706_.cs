using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Problems
{
    //706. Design HashMap
    //Design a HashMap without using any built-in hash table libraries.

    //Implement the MyHashMap class:

    //MyHashMap() initializes the object with an empty map.
    //void put(int key, int value) inserts a (key, value) pair into the HashMap.If the key already exists in the map, update the corresponding value.
    //int get(int key) returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
    //void remove(key) removes the key and its corresponding value if the map contains the mapping for the key.
    internal class _706_
    {
        int[] arr = new int[1000001];
        public _706_()
        {

        }
        public void Put(int key, int value)
        {
            arr[key] = value + 1;
        }

        public int Get(int key)
        {
            return arr[key] - 1;
        }

        public void Remove(int key)
        {
            arr[key] = 0;
        }
    }
}
