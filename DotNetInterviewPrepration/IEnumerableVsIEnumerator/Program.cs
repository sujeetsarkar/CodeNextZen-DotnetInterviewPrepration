using System;
using System.Collections.Generic;

namespace IEnumerableVsIEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oyears = new List<int>();
            oyears.Add(1990);
            oyears.Add(1991);
            oyears.Add(1992);
            oyears.Add(1993);
            oyears.Add(1994);
            oyears.Add(1995);
            oyears.Add(1996);
            oyears.Add(1997);
            oyears.Add(1998);

            // IEnumerable is actually sugar coting of IEnumerator, it actually uses IEnumerator internally, just to make syntax easy it is made.
            // State: IEnumerable does not remember which row(cursor position) it is iterating while IEnumerator does //
            IEnumerable<int> ienum = (IEnumerable<int>)oyears;
            //ienum.GetEnumerator();
            foreach (int item in ienum)
            {
                Console.WriteLine(item);
            }

            IEnumerator<int> ienumerator = oyears.GetEnumerator();
            while (ienumerator.MoveNext())
            {
                Console.WriteLine(ienumerator.Current);
            }
            // uncomment below line to see how IEnumerator saves the status.
            //Iterate1990to1994(ienumerator);
        }
        static void Iterate1990to1994(IEnumerator<int> o)
        {
            Console.WriteLine("Iterate1990to1994 entered");
            Console.WriteLine(o.Current);
            while (o.MoveNext())
            {
                Console.WriteLine(o.Current);
                if(o.Current > 1994)
                {
                    Iterate1994andAbove(o); // the value will be passed with current cursor position hence it will not go in infinite loop
                    // debug for more information
                }
            }
        }
        static void Iterate1994andAbove(IEnumerator<int> o)
        {
            Console.WriteLine(o.Current);
        }
    }
}
