namespace Foundation4
{
    public abstract class Activity
    {
        protected string _date;
        protected int _lengthInMinutes;
        protected string _activity;

        public Activity(string date, int lengthInMinutes)
        {
            this._date = date;
            this._lengthInMinutes = lengthInMinutes;
        }

        public abstract float GetDistance();

        public abstract float GetSpeed();

        public abstract float GetPace();

        public void GetSummary()
        {
            Console.WriteLine($"{this._date} {this._activity} ({this._lengthInMinutes} min)- Distance {this.GetDistance()} miles, Speed {this.GetSpeed()} mph, Pace: {this.GetPace()} min per mile");
        }
    }
}