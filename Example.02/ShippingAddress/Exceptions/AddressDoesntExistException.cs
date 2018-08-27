using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingAddress.Exceptions
{
    public class AddressDoesntExistException : Exception
    {
        public AddressDoesntExistException(string address)
            : base($"{address} doesn't exist")
        { }
    }
}
