using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeNextZen_Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("suj", "Sujeet");
            ht.Add(1, "Sumit");
            ht.Add(2, "Sumit"); //Can have duplicate value but bet should have different key
            //ht.Add(1, "Sumit"); // error
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Value);
            }
            var r1 = ht.Contains(1); //finds key
            var r2 = ht.ContainsKey("suj"); //finds key
            var r3 = ht.ContainsValue("Sujeet");
            HashSet<double> hs1 = new HashSet<double>();
            HashCode hc = new HashCode(); // Structure Hashcode of class/ object
            hc.Add("ABC");
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Sujeet");
            hs.Add("Sumit");
            hs.Add("Sumit"); // duplicate entry but no error but does not pushes into the HashSet, hs will cantain only two item
            int cnt = hs.Count;  //cnt = 2
            bool res1 = hs.Contains("Sujeet");

        }
    }
}
//--------------------------------------------------------------------------------------------------------------|
//					                    Hashtable Vs Dictionary                                                 |
//--------------------------------------------------------------------------------------------------------------|
//			HASHTABLE		                      |			DICTIONARY                                          |
//--------------------------------------------------------------------------------------------------------------|
//	A Hashtable is a non-generic collection.      |	A Dictionary is a generic collection.                       |
//	Hashtable is defined under System.Collections |	Dictionary is defined under System.Collections.Generic      |
//	namespace.				                      |	namespace.                                                  |
//	In Hashtable, you can store key/value pairs of|  In Dictionary, you can store key/value pairs of same type. |
//	the same type or of the different type.	      |                                                             |
//	In Hashtable, there is no need to specify the |	In Dictionary, you must specify the type of key and value.  |
//	type of the key and value.		              |                                                             |
//	The data retrieval is slower than Dictionary  |	The data retrieval is faster than Hashtable due to no       |
//	due to boxing/ unboxing.		              |	boxing/ unboxing.                                           |
//	In Hashtable, if you try to access a key that |	In Dictionary, if you try to access a key that doesn’t      |
//	doesn’t present in the given Hashtable,	      |	present in the given Dictionary, then it will give error.   |
//	then it will give null values.	 	          |                                                             |
//	It is thread safe.			                  |	It is also thread safe but only for public static members.  |
//	It doesn’t maintain the order of stored values|	It always maintain the order of stored values.              |
//--------------------------------------------------------------------------------------------------------------|