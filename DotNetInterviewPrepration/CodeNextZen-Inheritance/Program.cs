using System;

namespace CodeNextZen_Inheritance
{
    /* Inheritance : The ability of creating a new class from an existing class.
     * Inheritance is when an object acquires the property of another object.
     * Inheritance allows a class (subclass) to acquire the properties and behavior of another class (super-class). 
     * It helps to reuse, customize and enhance the existing code. So it helps to write a code accurately and reduce the development time.
     */
    class Program
    {
        static void Main(string[] args)
        {

            // Inheritance 
            Child child = new Child();
            child.Print();              //Child New Print
            child.PrintChild();         //Child PrintChild
            child.VirtualPrint();       //Child VirtualPrint
            child.PrintParent();        //Parent PrintParent

            Parent parent = new Parent();
            parent.Print();             //Parent Print
            parent.PrintParent();       //Parent PrintParent
            parent.VirtualPrint();      //Parent VirtualPrint

            Parent parentChild = new Child(); //parentChild can access parent's member as well as Child's copy of virtual methods
            parentChild.Print();        //Parent Print
            parentChild.PrintParent();  //Parent PrintParent
            parentChild.VirtualPrint(); //Child VirtualPrint

            // Child childParent = new Parent(); // not allowed

            // AbstractClass abstractClass = new AbstractClass(); //error: cannot create instance of abstract class or interface
            Console.WriteLine("********************************************************");
            DerivedAbstract1 derivedAbstract1 = new DerivedAbstract1();
            derivedAbstract1.AbstractMethod();  //DerivedAbstract1: AbstractMethod
            derivedAbstract1.Method1();         //AbstractClass Method  

            DerivedAbstract2 derivedAbstract2 = new DerivedAbstract2();
            derivedAbstract2.AbstractMethod();  //DerivedAbstract2: AbstractMethod
            derivedAbstract2.Method1();         //AbstractClass Method  

            DerivedAbstract3 derivedAbstract3 = new DerivedAbstract3();
            derivedAbstract3.AbstractMethod();  //DerivedAbstract2: AbstractMethod
            derivedAbstract3.Method1();         //AbstractClass Method  

            AbstractClass derivedAbstract = new DerivedAbstract2(); // AbstractClass own method as well as DerivedAbstract2 (child) abstract method
            derivedAbstract.AbstractMethod();   //DerivedAbstract2: AbstractMethod
            derivedAbstract.Method1();          //AbstractClass Method
        }
    }
    public class Parent
    {
        public void PrintParent()
        {
            Console.WriteLine("Parent PrintParent");
        }
        public void Print()
        {
            Console.WriteLine("Parent Print");
        }
        public virtual void VirtualPrint()
        {
            Console.WriteLine("Parent VirtualPrint");
        }
    }

    public class Child : Parent
    {
        public void PrintChild()
        {
            Console.WriteLine("Child PrintChild");
        }
        public new void Print()
        {
            Console.WriteLine("Child New Print");
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("Child VirtualPrint");
        }
    }
}
