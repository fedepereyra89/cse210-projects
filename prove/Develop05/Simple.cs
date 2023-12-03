namespace Develop05
{
    public class Simple : Goals
    {
        private bool _isComplete = false;

        public void SetIsComplete(bool isComplete)
        {
            this._isComplete = isComplete;
        }

        public bool GetIsComplete()
        {
            return this._isComplete;
        }

        public override List<string> CreateGoal()
        {
            Console.Write("What is the name of your goal? ");
            this.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            this.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            this.SetPoints(Convert.ToInt32(Console.ReadLine()));
            List<string> simpleGoal = new List<string>();
            simpleGoal.Add("Simplegoal");
            simpleGoal.Add($"{this.GetName()}");
            simpleGoal.Add(this.GetDescription());
            simpleGoal.Add(Convert.ToString(this.GetPoints()));
            simpleGoal.Add(Convert.ToString(this._isComplete));
            return simpleGoal;
        }
    }
}