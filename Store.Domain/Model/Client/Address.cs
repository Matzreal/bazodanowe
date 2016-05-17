namespace Store.Domain.Model.Client
{
    public class Address    // Value object
    {
        public Address(string Street, string City, string Region, string Country, string PostalCode)
        {
            this.Street = Street;
            this.City = City;
            this.Region = Region;
            this.Country = Country;
            this.PostalCode = PostalCode;
        }

        private Address() { }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
    }
}
