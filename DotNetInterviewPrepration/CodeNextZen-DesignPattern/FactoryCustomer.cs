using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNextZen_DesignPattern
{
    public static class FactoryCustomer // Design Pattern:- Simple Factory Pattern
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        //Way2
        //static FactoryCustomer()
        //{
        //    custs.Add("Customer", new Customer());
        //    custs.Add("Lead", new Lead());
        //}
        public static CustomerBase Create(string TypeCust)
        {

            //Way1
            //if(TypeCust == "Customer")
            //{
            //    return new Customer();
            //}
            //else
            //{
            //    return new Lead();
            //}
            //way3
            if(custs.Count == 0) //Design Pattern:- Lazy loading (opp eager loading)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }
            // Design Pattern:- RIP - Replace If with polymorphism
            return custs[TypeCust];
        }
    }
}
