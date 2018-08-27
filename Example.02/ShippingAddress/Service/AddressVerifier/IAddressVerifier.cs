using ShippingAddress.Model;

namespace ShippingAddress.Service.AddressVerifier
{
    public interface IAddressVerifier
    {
        bool Verify(Address address);
    }
}
