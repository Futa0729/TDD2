namespace QuestProgressTracker
{

    public class Objective
    {
        public string Name { get; set; }
        public int RequiredAmount { get; set; }

        private int _currentAmount;
        public int CurrentAmount 
        { 
            get { return _currentAmount; }
            set
            {
                if (value > RequiredAmount)
                    _currentAmount = RequiredAmount;
                
                else
                    _currentAmount = value;
            }
        }

        public Objective(string name, int requiredAmount)
        {
            Name = name;
            RequiredAmount = requiredAmount;
            CurrentAmount = 0;
        }
    }
}
