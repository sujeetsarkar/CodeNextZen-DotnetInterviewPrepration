using System;
using System.Collections.Generic;
using static System.Collections.Generic.Dictionary<int, string>;

namespace CodeNextZen_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Sujeet");
            dict.Add(2, "Sujeet");
            dict.Add(3, "Sujeet");
            dict.Add(4, "Sujeet");
            dict.Add(5, "Sujeet");
            KeyCollection key = dict.Keys;
        }
    }
}
