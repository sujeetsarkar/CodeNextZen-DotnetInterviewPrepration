using System;
using System.Collections.Generic;

namespace LamdbaExpression
{
    class Program
    {
        // normal delegate call
        //delegate double CalArePointer(int r);
        //static CalArePointer cpointer = CalculateArea;
        //static void Main(string[] args)
        //{
        //    double area = cpointer.Invoke(20);
        //}
        //static double CalculateArea(int r)
        //{
        //    return 3.14 * r * r;
        //}

        // delegate call using Annonumous Method
        //delegate double CalArePointer(int r);
        //static void Main(string[] args)
        //{
        //    CalArePointer cpointer = new CalArePointer(
        //        delegate (int r)
        //        {
        //            return 3.14 * r * r;
        //        }
        //        );
        //    double Area = cpointer(20);
        //}

        // delegate call using Lambda Expressio
        //delegate double CalArePointer(int r);
        //static void Main(string[] args)
        //{
        //    CalArePointer cpointer = r => 3.14 * r * r;
        //    double Area = cpointer(20);
        //}

        // delegate call using generic delegate (Func)
        //static void Main(string[] args)
        //{
        //    Func<Double, Double> cpoinnter = r => 3.14 * r * r;
        //    double Area = cpoinnter(20);
        //}


        // delegate call using generic delegate (Action)(use: when we do not expect any return)
        //static void Main(string[] args)
        //{
        //    Action<string> MyAction = y => Console.Write(y);
        //    MyAction("Hello");
        //}

        // delegate call using generic delegate (Predicate)(use: only to check)
        static void Main(string[] args)
        {
            Predicate<string> CheckGreaterThan5 = x => x.Length > 5;
            Console.WriteLine(CheckGreaterThan5("SujeetKumar")
                );
        }
    }
}
