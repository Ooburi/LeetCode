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
        public class ListNode
        {
            public int Key { get; set; }
            public int Value { get; set; }
            public ListNode Next { get; set; }

            public ListNode(int key = -1, int value = -1, ListNode next = null)
            {
                Key = key;
                Value = value;
                Next = next;
            }
        }
        public class MyHashMap
        {

            private ListNode[] map;
            public MyHashMap()
            {
                map = new ListNode[1000];
            }

            private int Hash(int key)
            {
                return key % map.Length;
            }

            public void Put(int key, int value)
            {
                int index = Hash(key);
                ListNode current = map[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        current.Value = value;
                        return;
                    }
                    current = current.Next;
                }

                map[index] = new ListNode(key, value, map[index]);
            }

            public int Get(int key)
            {
                int index = Hash(key);
                ListNode current = map[index];

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        return current.Value;
                    }
                    current = current.Next;
                }

                return -1;
            }

            public void Remove(int key)
            {
                int index = Hash(key);
                ListNode current = map[index];
                ListNode prev = null;

                while (current != null)
                {
                    if (current.Key == key)
                    {
                        if (prev != null)
                        {
                            prev.Next = current.Next;
                        }
                        else
                        {
                            map[index] = current.Next;
                        }
                        return;
                    }
                    prev = current;
                    current = current.Next;
                }
            }
        }

    }
}
