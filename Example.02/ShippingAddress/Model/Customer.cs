using System;

namespace ShippingAddress.Model
{
    public class Customer
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public Address ShippingAddress { get; set; }
    }
}
