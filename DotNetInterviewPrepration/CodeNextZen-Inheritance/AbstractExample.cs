using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNextZen_Inheritance
{
    public abstract class AbstractClass
    {
        public abstract void AbstractMethod();
        public void Method1()
        {
            Console.WriteLine("AbstractClass Method  ");
        }
    }

    public class DerivedAbstract1 : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedAbstract1: AbstractMethod");
        }
    }
    public class DerivedAbstract2 : AbstractClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("DerivedAbstract2: AbstractMethod");
        }
    }
    public class DerivedAbstract3 : DerivedAbstract2
    {
    }
}
