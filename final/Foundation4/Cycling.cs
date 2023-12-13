namespace Foundation4
{
    public class Cycling : Activity
    {
        private float _speed;

        public Cycling(string date, int lengthInMinutes, float speed) : base(date, lengthInMinutes)
        {
            this._activity = "Cycling";
            this._speed = speed;
        }

        public override float GetPace()
        {
            return 60 / this._speed;
        }

        public override float GetDistance()
        {
            return (this._speed * this._lengthInMinutes) / 60;
        }

        public override float GetSpeed()
        {
            return this._speed;
        }
    }
}