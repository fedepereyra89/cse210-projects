namespace Foundation3
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
        {
            this._speaker = speaker;
            this._capacity = capacity;
            this._type = "Lecture";
        }


        public void GetFullDetails()
        {
            Console.WriteLine($"\n{this._title}\n{this._type}\n{this._description}\n{this._date}\n{this._time}\n{this._address.GetAddressAsString()}\n{this._speaker}\n{this._capacity}");
        }
    }
}