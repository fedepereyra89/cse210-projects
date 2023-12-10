namespace Foundation2
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            this._name = name;
            this._address = address;
        }

        public string GetName()
        {
            return this._name;
        }

        public Address GetAddress()
        {
            return this._address;
        }

        public bool IsInUSA()
        {
            return this._address.IsInUSA();
        }
    }
}