using System;
using System.Collections;

namespace CodeNextZen_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies;
            movies = new string[3];
            movies[0] = "Movie1";
            movies[1] = "Movie2";
            movies[2] = "Movie3";
            // movies[3] = "Movie4"; // System.IndexOutOfRangeException

            string[] Story = new string[] { "", "", "" };
            string[] Films = new string[3];
            Films[0] = "Movie1";
            Films[1] = "Movie2";
            Films[2] = "Movie3";

            string[] Stories = new string[3] { "sumit", "sujeet", "abhi" };
            Array.Sort(Stories);
            Array.BinarySearch(Stories, "abhi");
            Array.Reverse(Stories);
            Array.Copy(Stories, 0, Story,0, 3);
            string[] movie = { "", "", "" };
            Array.Clear(Stories, 1, 2);
            // 2-D Array
            string[,] array = new string[4, 2] { { "A", "B" }, { "C", "D" }, { "E", "F" }, { "G", "H" } };
            //Multi-Dimensional Array
            string[,,] multiArray = new string[,,] { //3,2,2
                { 
                    { "A", "B" }, { "A", "B" }
                },
                {
                    { "A", "B" }, { "A", "B" }
                },
                {
                    { "A", "B" }, { "A", "B" }
                }
            };
            //Jagged Array
            string[][] jaggedArray = new string[3][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new string[i + 2];
            }

            // BitArray

            // It is used when you need to store the bits but do not know the number of bits in advance.
            // You can access items from the BitArray collection by using an integer index, which starts from zero.
            byte[] a = { 60, 20 };
            BitArray bitArray = new BitArray(a); // convertes 60 and 20 into bits(0's and 1's) and stores as array
            bitArray.Get(13);
            bitArray.Get(30);
        }
    }
}
