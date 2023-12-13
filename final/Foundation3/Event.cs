namespace Foundation3
{
    public class Event
    {
        protected string _title;
        protected string _description;
        protected string _date;
        protected string _time;
        protected Address _address;
        protected string _type;
        

        public Event(string title, string description, string date, string time, Address address)
        {
            this._title = title;
            this._description = description;
            this._date = date;
            this._time = time;
            this._address = address;
        }

        public void GetStandardDetails()
        {
            Console.WriteLine($"\n{this._title}\n{this._description}\n{this._date}\n{this._time}\n{this._address.GetAddressAsString()}");
        }



        public void GetShortDescription()
        {
            Console.WriteLine($"\n{this._type}\n{this._title}\n{this._date}");
        }
    }
}