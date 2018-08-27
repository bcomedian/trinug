using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingAddress
{
    public class Address
    {
        public Guid AddressId { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
