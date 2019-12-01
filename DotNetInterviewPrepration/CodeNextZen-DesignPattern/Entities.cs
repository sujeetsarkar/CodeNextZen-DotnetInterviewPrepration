using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNextZen_DesignPattern
{
    public class CustomerBase
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }
        public virtual void Validate()
        {
            throw new NotImplementedException();
        }
    }
    public class Customer: CustomerBase
    {
        public override void Validate()
        {
            if(CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is Required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber is Required");
            }
            if (BillAmount <= 0)
            {
                throw new Exception("Bill Amount is Required");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Enter Valid BillDate");
            }
            if (Address.Length == 0)
            {
                throw new Exception("Address is Required");
            }
        }
    }
    public class Lead: CustomerBase
    {
        public override void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is Required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("PhoneNumber is Required");
            }
        }
    }
}
