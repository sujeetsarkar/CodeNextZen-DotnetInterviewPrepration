using System;

namespace CodeNextZen_Tuple
{
    /*
     * Con's:-
     * 1. Tuples can not be modified;
     * 2. Tuple is limited to include 8 elements.
     *    You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
     * Pro's:-
     * 1. When you want to return multiple values from a method without using ref or out parameters.
     * 2. When you want to pass multiple values to a method through a single parameter.
     * 3. When you want to hold a database record or some values temporarily without creating a separate class.
     * 
     * Diff:-
     * Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
     * ValueTuple is value(struct) type.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> tuple = new Tuple<int, string, string>(1, "Sujeet", "Kumar");
            int id = tuple.Item1;
            string FName = tuple.Item2;
            string LName = tuple.Item3;

            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            int n1 = numbers.Item1; // returns 1
            int n2 = numbers.Item7; // returns 7
            Tuple<int,int,int,int,int,int> n3 = numbers.Rest.Item1; //returns (8, 9, 10, 11, 12, 13)
            int n4 = numbers.Rest.Item1.Item1; //returns 8
            int n5 = numbers.Rest.Item1.Item2; //returns 9

            var numbers1 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            int n6 = numbers1.Item1; // returns 1
            int n7 = numbers1.Item2; // returns 2
            var n8 = numbers1.Item3; // returns (3, 4, 5, 6, 7,  8)
            int n9 = numbers1.Item3.Item1; // returns 3
            int n10 = numbers1.Item4; // returns 9
            int n11 = numbers1.Rest.Item1; //returns 13

            ValueTuple<int, string, string> vtuple = new ValueTuple<int, string, string>(1, "Sujeet", "Kumar");
            int n = vtuple.Item1;
        }
    }
}
