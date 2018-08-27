using ShippingAddress.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingAddress.Service.AddressVerifier
{
    public class DefaultAddressVerifier : IAddressVerifier
    {
        public bool Verify(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
