namespace Foundation4
{
    public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
        {
            this._activity = "Swimming";
            this._laps = laps;
        }

        public override float GetDistance()
        {
            return ((this._laps * 50) / (1000 * 0.62f));
        }

        public override float GetPace()
        {
            return 60 / this.GetSpeed();
        }

        public override float GetSpeed()
        {
            return (this.GetDistance() / this._lengthInMinutes) * 60;
        }
    }
}