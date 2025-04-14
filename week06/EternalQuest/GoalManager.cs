public class GoalManager 
{
    private List<Goal> _goals;
    private int _score;
    private AchievementManager _achievementManager;

    public GoalManager() 
    {
        _goals = new List<Goal>();
        _score = 0;
        _achievementManager = new AchievementManager();
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": running = false; break;
                default: Console.WriteLine("Invalid choice. Please try again."); break;
            }

            _achievementManager.CheckAchievements(_score, _goals);
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score: {_score}");
    }

    public void ListGoalNames()
    {   
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetType().Name}: {_goals[i].GetDetailsString()}");
        }    
    }

    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal you want to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select a choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points, false));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target number of times to complete this goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing this goal: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus, 0));
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not created.");
                break;
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select the goal you want to record an event for:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= _goals.Count)
        {
            Goal selectedGoal = _goals[index - 1];
            selectedGoal.RecordEvent();

            if (selectedGoal is ChecklistGoal checklist)
            {
                _score += checklist.Points;
                if (checklist.IsComplete())
                {
                    _score += checklist.Bonus;
                    _achievementManager.CheckAchievements(_score, _goals);
                }
            }
            else
            {
                _score += selectedGoal.Points;
                _achievementManager.CheckAchievements(_score, _goals);

            }    
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        } 
    }

    public void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {   
            output.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");

    }

    public void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            if (lines.Length > 0)
            {
                _score = int.Parse(lines[0]);
                _goals.Clear();
            
                for (int i = 1; i < lines.Length; i++)
                {   
                    string line = lines[i];
                    string[] parts = line.Split(':');
                    
                    if (parts.Length != 2)
                    {
                        continue;
                    }

                    string type = parts[0];
                    string[] data = parts[1].Split('|');

                    if (type == "SimpleGoal" && data.Length >= 4)
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        bool isComplete = bool.Parse(data[3]);

                        _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    }
                    else if (type == "EternalGoal" && data.Length >= 3)
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);

                        _goals.Add(new EternalGoal(name, description, points));
                    }
                    else if (type == "ChecklistGoal" && data.Length >= 6)
                    {
                        string name = data[0];
                        string description = data[1];
                        int points = int.Parse(data[2]);
                        int target = int.Parse(data[3]);
                        int bonus = int.Parse(data[4]);
                        int amountCompleted = int.Parse(data[5]);

                        _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                    }
                }

                Console.WriteLine("Goals loaded successfully.");
            }
            else
            {
                Console.WriteLine("The file is empty.");
            }
        } 
        else
        {
            Console.WriteLine("File not found.");
        }
    }    
}