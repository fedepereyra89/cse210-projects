namespace Develop05
{
    public class Eternal : Goals
    {
        public override List<string> CreateGoal()
        {
            Console.Write("What is the name of your goal? ");
            this.SetName(Console.ReadLine());
            Console.Write("What is a short description of it? ");
            this.SetDescription(Console.ReadLine());
            Console.Write("What is the amount of points associated with this goal? ");
            this.SetPoints(Convert.ToInt32(Console.ReadLine()));
            List<string> eternalGoal = new List<string>();
            eternalGoal.Add("Eternalgoal");
            eternalGoal.Add($"{this.GetName()}");
            eternalGoal.Add(this.GetDescription());
            eternalGoal.Add(Convert.ToString(this.GetPoints()));
            return eternalGoal;
        }
    }
}
