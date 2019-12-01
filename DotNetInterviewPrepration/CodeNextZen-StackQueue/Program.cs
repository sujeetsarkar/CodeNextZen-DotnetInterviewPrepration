using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeNextZen_StackQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack stack = new Stack();
            stack.Push("ABC");
            stack.Push(1);
            object obj = stack.Pop();
            string resp = (string)stack.Pop();
            Stack<string> genStack = new Stack<string>();
            genStack.Push("BCD");
            string res = genStack.Pop();

            //Queue
            Queue queue = new Queue();
            queue.Enqueue("ABC");
            object obj1 = queue.Dequeue();


            Queue<string> genQueue = new Queue<string>();
            genQueue.Enqueue("BCD");
            string res1 = genQueue.Dequeue();
        }
    }
}
