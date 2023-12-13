namespace Foundation4
{
    public class Running : Activity
    {
        private float _distance;

        public Running(string date, int lengthInMinutes, float distance) : base(date, lengthInMinutes)
        {
            this._activity = "Running";
            this._distance = distance;
        }

        public override float GetDistance()
        {
            return this._distance;
        }

        public override float GetSpeed()
        {
            return ((this._distance / this._lengthInMinutes) * 60);
        }

        public override float GetPace()
        {
            return (60 / this.GetSpeed());
        }
    }
}