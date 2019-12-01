using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeNextZen_List
{
    // List:  Singly linked list
    // LinkedList: Doubly Linked List
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Sujeet");
            list.Add("Kumar");
            list.Add("Swati");
            list.Add("Jaiswal");

            List<string> list1 = new List<string>();
            list1.Add("Sumit");
            list1.Add("Kumar");

            list.AddRange(list1);
            bool res = list.Contains("Kumar");
            // list.Insert(8, "Pari"); // System.ArgumentOutOfRangeException
            list.Remove("Pari");
            string[] str = list.ToArray();

            // LinkedList
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("ABC");
            linkedList.AddFirst("DEF");
            linkedList.AddLast("GHI");
            linkedList.AddFirst("JKL");
            LinkedListNode<string> result = linkedList.Find("DEF");
            linkedList.AddAfter(result, "MNO");
            linkedList.AddBefore(result, "ABC");
            var res1 = linkedList.First;

            // SortedList
            SortedList sl = new SortedList();
            SortedList<int, string> genSl = new SortedList<int, string>();
            SortedList sortedList1 = new SortedList();
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            sortedList1.Add(1, "One");
            sortedList1.Add(5, "Five");
            sortedList1.Add(2, "Two");

            SortedList sortedList2 = new SortedList();
            sortedList2.Add("one", 1);
            sortedList2.Add("two", 2);
            sortedList2.Add("three", 3);
            sortedList2.Add("four", 4);

            SortedList sortedList3 = new SortedList();
            sortedList3.Add(1.5, 100);
            sortedList3.Add(3.5, 200);
            sortedList3.Add(2.4, 300);
            sortedList3.Add(2.3, null);
            sortedList3.Add(1.1, null);

            // Key of different datatypes throws exception
            SortedList sortedList = new SortedList();

            sortedList.Add(3, "Three");
            // sortedList.Add("Four", "Four"); // Throw exception: InvalidOperationException
            sortedList.Add(1, "One");
            sortedList.Add(8, "Five");
            sortedList.Add(2, "Two");

            // Example: Access values using foreach
            SortedList sortedLists = new SortedList()
                        {
                                {3, "Three"},
                                {4, "Four"},
                                {1, "One"},
                                {5, "Five"},
                                {2, "Two"}
                        };
            foreach (DictionaryEntry kvp in sortedLists)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            sortedLists.Remove(3);//removes element whose key is 3
            sortedLists.RemoveAt(0);//removes element at zero index i.e first element: One
            sortedLists.Contains(6); // returns false

            sortedLists.ContainsKey(2); // returns true

            sortedLists.ContainsValue("Five"); // returns true

        }
    }
}
