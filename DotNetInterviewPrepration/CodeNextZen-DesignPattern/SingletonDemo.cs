using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNextZen_DesignPattern
{
    public sealed class SingletonDemo
    {
        public static int counter;
        private static SingletonDemo instance = null;
        private SingletonDemo()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public static SingletonDemo getInstance {
            get
            {
                if (instance == null)
                    instance = new SingletonDemo();
                return instance;
            }
        }
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
