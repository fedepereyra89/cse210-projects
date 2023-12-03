namespace Develop05
{
    public abstract class Goals
    {
        private string _name;
        private string _description;
        private int _points;
        
        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }

        public string GetDescription()
        {
            return this._description;
        }

        public void SetPoints(int points)
        {
            this._points = points;
        }

        public int GetPoints()
        {
            return this._points;
        }

        public abstract List<string> CreateGoal();

    }
}