using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if(addressId == 1)
            {
                address.StreetLine1 = "Radnicka 47";
                address.StreetLine2 = "Bul Z.Dindjica";
                address.City = "Belgrade";
                address.State = "Serbia";
                address.PostalCode = "11000";
                address.Country = "Serbia";
            }
            return address;
        }
        public bool Save(Address address)
        {
            return true;
        }
        public IEnumerable<Address>RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Majke Jevrosime bb",
                StreetLine2 = "selo Zuce",
                City = "Beograd",
                State = "Srbija",
                PostalCode = "11000",
                Country = "Srbija"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Rige od Fere 3",
                City = "Beograd",
                State = "Srbija",
                PostalCode = "11000",
                Country = "Srbija"
            };
            addressList.Add(address);
            return addressList;
            
        
        }
        
    }
}
