using System;

namespace CodeNextZen_Delegate
{
    //Party 1 wants to Know fow which value of i second party is currently running for Loop from LongRunning Method.
    // Second Party Says that you send me your delegate and I will make sure that, will get value of i.


    //First Party
    class Program
    {
        // Delegate :- The Who Communication Petween Two Parties
        public delegate void SomeMethodPtr();
        #region //below code is of no use in terms of using delegate (function pointer)
        //static void Main(string[] args)
        //{
        //    Program prg = new Program();
        //    SomeMethodPtr obj = new SomeMethodPtr(prg.SomeMethod);
        //    obj.Invoke();
        //    Console.ReadLine();
        //}
        //public void SomeMethod()
        //{
        //    Console.WriteLine("Method Called");
        //}
        #endregion


        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunning(Callback);
            Console.ReadLine();
        }
        static void Callback(int i)
        {
            Console.WriteLine(i);
        }
    }

    //Second Party
    public class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunning(CallBack obj)
        {
            for (int i = 0; i < 100000; i++)
            {
                //Does Something
                obj(i);
            }
        }
    }
}
