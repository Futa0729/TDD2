namespace QuestProgressTracker
{
    public class Quest
    {
        private List<Objective> objectives;
        private bool isTurnedIn;

        public Quest(string v)
        {
            objectives = new List<Objective>();
            isTurnedIn = false;
        }

        public bool IsCompleted 
        { 
            get    
            {
                if (isTurnedIn == false)
                    return false;
                    
                if (objectives.Count == 0)
                    return false;

                foreach (Objective objective in objectives)
                {
                    if (objective.CurrentAmount < objective.RequiredAmount)
                        return false;
                }

                return true;
            }
        }

        public void AddObjective(string v1, int v2)
        {
            objectives.Add(new Objective(v1, v2));
        }

        public Objective GetObjective(string v)
        {
            foreach (Objective objective in objectives)
            {
                if (objective.Name == v)
                    return objective;
            }

            return null;
        }

        public void ProgressObjective(string v1, int v2)
        {
            if (v2 < 0)
                throw new Exception();

            Objective objective = GetObjective(v1);

            if (objective == null)
                throw new Exception();

            objective.CurrentAmount += v2;
        }

        public void TurnIn()
        {
            isTurnedIn = true;
        }
    }
}
