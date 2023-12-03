namespace Develop05
{
    public class Menu
    {
        private string _type;
        private string _selection;
        private int _totalPoints;
        private List<List<string>> _goals = new List<List<string>>();

        public void AddGoalToList(List<string> goal)
        {
            this._goals.Add(goal);
        }

        public List<List<string>> GetGoalList()
        {
            return this._goals;
        }

        public void SetType(string type)
        {
            this._type = type;
        }

        public string GetType()
        {
            return this._type;
        }

        public void SetSelection(string selection)
        {
            this._selection = selection;
        }

        public string GetSelection()
        {
            return this._selection;
        }

        public void SetTotalPoints(int totalPoints)
        {
            this._totalPoints = totalPoints;
        }

        public int GetTotalPoints()
        {
            return this._totalPoints;
        }

        public void PrintTotalPoints()
        {
            Console.WriteLine($"\nYou have {this._totalPoints} points.\n");
        }

        public void StartMenu()
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            this._selection = Console.ReadLine();
        }

        public void SelectType()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            this._type = Console.ReadLine();
        }
    }
}