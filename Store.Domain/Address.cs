using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Address    // Value object
    {
        public Address(string street, string city, string region, string country, string postalCode)
        {
            Street = street;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
    }
}
