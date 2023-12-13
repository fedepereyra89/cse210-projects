namespace Foundation3
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _district;
        private string _country;

        public Address(string streetAddress, string city, string district, string country)
        {
            this._streetAddress = streetAddress;
            this._city = city;
            this._district = district;
            this._country = country;
        }

        public string GetAddressAsString()
        {
            return $"{this._streetAddress}  {this._city}, {this._district}  {this._country}";
        }
    }
}