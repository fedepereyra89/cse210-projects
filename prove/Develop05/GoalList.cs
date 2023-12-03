namespace Develop05
{
    public class GoalList
    {
        private List<List<string>> _goals = new List<List<string>>();

        public void AddGoal(List<string> goal)
        {
            this._goals.Add(goal);
        }

        public List<List<string>> GetGoals()
        {
            return this._goals;
        }
    }
}