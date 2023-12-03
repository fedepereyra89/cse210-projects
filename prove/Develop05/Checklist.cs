namespace Develop05
{
    public class Checklist : Goals
    {
        private int _checkpoint;
        private int _bonusPoints;

        private int _completions;

        public int GetCheckpoint()
        {
            return this._checkpoint;
        }

        public int GetBonusPoints()
        {
            return this._bonusPoints;
        }
        public override List<string> CreateGoal()
        {
            Console.Write("What is the name of your goal? ");
            this.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            this.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            this.SetPoints(Convert.ToInt32(Console.ReadLine()));
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            this._checkpoint = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            this._bonusPoints = Convert.ToInt32(Console.ReadLine());
            List<string> checklistGoal = new List<string>();
            checklistGoal.Add("Checklistgoal");
            checklistGoal.Add($"{this.GetName()}");
            checklistGoal.Add(this.GetDescription());
            checklistGoal.Add(Convert.ToString(this.GetPoints()));
            checklistGoal.Add(Convert.ToString(this._bonusPoints));
            checklistGoal.Add(Convert.ToString(this._checkpoint));
            checklistGoal.Add("0");
            return checklistGoal;
        }
    }
}