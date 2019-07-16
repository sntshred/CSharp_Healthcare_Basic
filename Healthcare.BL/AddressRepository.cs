using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressid)
        {
            Address address = new Address(addressid);

            if (addressid == 1)
            {
                address.AddressType = 1;
                address.StreeLine1 = "Bag End";
                address.StreeLine2 = "2301 cam stree";
                address.City = "Cwp";
                address.Country = "US";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByPatientId(int patientId)
        {
            var addressList = new List<Address>();

            var address1 = new Address(1);
            address1.AddressType = 1;
            address1.StreeLine1 = "Bag End";
            address1.StreeLine2 = "2301 cam stree";
            address1.City = "Cwp";
            address1.Country = "US";

            addressList.Add(address1);


            var address2 = new Address(2);
            address2.AddressType = 2;
            address2.StreeLine1 = "Bag End2";
            address2.StreeLine2 = "2301 cam2 stree";
            address2.City = "Cwp2";
            address2.Country = "US";

            addressList.Add(address2);



            return addressList;
        }



        public bool Save(Address address)
        {
            return true;
        }
    }
}
