using System;
using System.Linq;
using System.Collections.Generic;
using ShippingAddress.Model;
using ShippingAddress.Service.AddressVerifier;
using ShippingAddress.Exceptions;

namespace ShippingAddress.Repository
{
    public class InMemoryRepository
    {
        private readonly IAddressVerifier _addressVerifier;

        public List<Customer> Customers { get; private set; }

        public InMemoryRepository(IAddressVerifier addressVerifier)
        {
            _addressVerifier = addressVerifier;
        }

        public void Add(Customer customer)
        {

        }

        public void AddAddress(Address address, Guid customerId)
        {
            var customerToUpdate = Customers.FirstOrDefault(x => x.CustomerId == customerId);
            if (customerToUpdate == null)
            {
                throw new Exception("Customer is not found");
            }

            var addressExisted = _addressVerifier.Verify(address);
            if (!addressExisted)
            {
                throw new AddressDoesntExistException(address.ToString());
            }
        }
    }
}
