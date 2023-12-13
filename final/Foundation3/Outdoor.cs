namespace Foundation3
{
    public class Outdoor : Event
    {
        private string _weatherStatement;

        public Outdoor(string title, string description, string date, string time, Address address, string weatherStatment)  : base(title, description, date, time, address)
        {
            this._weatherStatement = weatherStatment;
            this._type = "Outdoor";
        }

        public void GetFullDetails()
        {
            Console.WriteLine($"\n{this._title}\n{this._type}\n{this._description}\n{this._date}\n{this._time}\n{this._address.GetAddressAsString()}\n{this._weatherStatement}");
        }
    }
}