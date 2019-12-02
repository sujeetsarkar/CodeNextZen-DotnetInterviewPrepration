using System;

namespace CodeNextZen_Out_Ref_Params
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutUsage
            Divide(10, 3, out int res, out int rem);
            Console.WriteLine("{0} and {1}", res, rem); // Outputs "3 and 1"

            //SwapExample
            int i = 1, j = 2;
            Swap(ref i, ref j);
            Console.WriteLine($"{i} {j}");    // Outputs "2 1"
        }
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Divide(int x, int y, out int result, out int remainder)
        {
            result = x / y;
            remainder = x % y;
        }
    }
}
