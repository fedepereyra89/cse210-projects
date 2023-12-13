namespace Foundation3
{
    public class Reception : Event
    {
        private string _email;

        public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
        {
            this._email = email;
            this._type = "Reception";
        }

        public void GetFullDetails()
        {
            Console.WriteLine($"\n{this._title}\n{this._type}\n{this._description}\n{this._date}\n{this._time}\n{this._address.GetAddressAsString()}\n{this._email}");
        }
    }
}