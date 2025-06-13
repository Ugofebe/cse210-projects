public class GoalManager //: Goal
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest Program");
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        
        string type = Console.ReadLine();
        
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("\nCurrent Goals:");
        foreach (var goal in _goals)
        {
            string completion = goal.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{completion} {goal.GetDetailsString()}");
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i]._shortName}");
        }
        
        int selection = int.Parse(Console.ReadLine()) - 1;
        _goals[selection].RecordEvent();
        _score += _goals[selection]._points;
        
        if (_goals[selection] is ChecklistGoal cg && cg.IsComplete())
        {
            _score += cg.GetBonus();
            Console.WriteLine($"Bonus earned! +{cg.GetBonus()} points");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        
        _goals.Clear();
        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] details = parts[1].Split(",");
            
            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(
                        details[0], details[1], int.Parse(details[2]),
                        int.Parse(details[4]), int.Parse(details[3])));
                    break;
            }
        }
    }
}