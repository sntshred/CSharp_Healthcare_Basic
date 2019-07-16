using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Healthcare.BL
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            Addressid = addressId;
            
        }

        public int Addressid { get; set; }
        public int AddressType { get; set; }
        public string StreeLine1{ get; set; }
        public string StreeLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int  PostalCode { get; set; }

        public string Country { get; set; }
               

        public bool Validate()
        {
            var isValid = true;
            if (PostalCode == null)
            {
                isValid = false;
            }

            return isValid;
        }

    }
}
