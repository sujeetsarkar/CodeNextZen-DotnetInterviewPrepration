using System;
using System.Collections;

namespace CodeNextZen_ArrayList
{
    //ArrayList: Non generic type of collection, Can contain any type of data, grows automatically
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(123);
            arrayList.Add("name");
            arrayList.Add(12.32);
            arrayList.Add('a');

            IList arrayLst = new ArrayList();
            arrayLst.Add(123);
            arrayLst.Add("name");
            arrayLst.Add(12.32);
            arrayLst.Add('a');

            ICollection arrayLst1 = new ArrayList();
            IEnumerable arrayLst2 = new ArrayList();

            IList arrayLst3 = new ArrayList() { 2, "Sujeet" };
            arrayList.AddRange(arrayLst3);
            arrayList.Insert(0, "Kumar");
            arrayList.Remove("name");
            arrayList.Remove("abc");
            arrayList.RemoveAt(0);
        }
    }
}
