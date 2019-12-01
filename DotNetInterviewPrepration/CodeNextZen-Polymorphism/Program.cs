using System;

namespace CodeNextZen_Polymorphism
{
    /*
     * There are two types of polymorphism in C#: compile time polymorphism and runtime polymorphism.
     * 1. Compile time polymorphism is achieved by method overloading and operator overloading in C#.
     *    It is also known as static binding or early binding.
     * 2. Runtime polymorphism in achieved by method overriding which is also known as dynamic binding or late binding.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();                    // eating bread...
            Console.WriteLine(a.color); // white
        }
    }

    // Runtime polymorphism
    public class Animal
    {
        public string color = "white";
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }
    public class Dog : Animal
    {
        public new string color = "black";
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }
    }
}
