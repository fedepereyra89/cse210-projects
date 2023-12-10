namespace Foundation2
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

        public bool IsInUSA()
        {
            switch (this._country)
            {
                case "USA":
                    return true;
                default:
                    return false;
            }
        }

        public string GetAddressAsString()
        {
            return $"{this._streetAddress}\n{this._city}\n{this._district}\n{this._country}";
        }
    }
}