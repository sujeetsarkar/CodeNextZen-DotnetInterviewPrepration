using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNextZen_DesignPattern
{
    public static class FactoryCustomer // Design Pattern:- Simple Factory Pattern
    {
        public static CustomerBase Create(string TypeCust)
        {
            if (TypeCust == "Customer")
            {
                return new Customer();
            }
            else
            {
                return new Lead();
            }
        }
    }
}
