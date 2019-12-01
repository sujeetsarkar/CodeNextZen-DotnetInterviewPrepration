using System;
using System.Text;

namespace CodeNextZen_StringBuilder
{
    /*
     * A String is immutable, meaning String cannot be changed once created.
     * Every time we modify the string it creates a new string in heap. This behaviour will hinder the performance.
     * StringBuilder is a dynamic object that allows you to expand the number of characters in the string.
     * It doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
     */
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello World");
            StringBuilder sb = new StringBuilder("Hello World");
            StringBuilder s = new StringBuilder(30);
            StringBuilder s1 = new StringBuilder("Hello World!!", 50);

            sb.Append("World!!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("This is new line.");
            /* Output:-
             * Hello World!! Hello C#!.
             * This is new line.
             */
            // Use AppendFormat method to format input string into specified format and then append it.
            StringBuilder amountMsg = new StringBuilder("Your total amount is ");
            amountMsg.AppendFormat("{0:C} ", 25);
            Console.WriteLine(amountMsg);
            // Output:-
            // Your total amount is $ 25.00

            StringBuilder sb1 = new StringBuilder("Hello World!!", 50);
            sb1.Insert(5, " C#");

            Console.WriteLine(sb1);
            // Output: Hello C# World!!

            StringBuilder sb2 = new StringBuilder("Hello World!!", 50);
            sb2.Remove(6, 7); // strartIndex, length

            Console.WriteLine(sb2);
            // Output: Hello

            StringBuilder sb3 = new StringBuilder("Hello World!!", 50);
            sb3.Replace("World", "C#"); // Replaces all occurance of "World" with "C#"

            Console.WriteLine(sb3);

            StringBuilder sb4 = new StringBuilder("Hello World!!");

            for (int i = 0; i < sb4.Length; i++)
                Console.Write(sb4[i]);
            // Output: Hello World!!

            StringBuilder sb5 = new StringBuilder("Hello World!!");

            string str = sb5.ToString(); // "Hello World!!"
        }
    }
}
