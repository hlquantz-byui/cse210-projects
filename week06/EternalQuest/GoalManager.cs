
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() { }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");

    }
    public void ListGoals()
    {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"{count}. [X] {goal.GetStringRepresentation()}");
            }
            else
            {
                Console.WriteLine($"{count}. [ ] {goal.GetStringRepresentation()}");
            }
            count++;

        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();

        if (input == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }
        else if (input == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (input == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
        else
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
    public void RecordEvent()
    {
        int count = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal1 in _goals)
        {
            Console.WriteLine($"{count}. {goal1.GetGoalDetails()}");
            count++;
        }
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < _goals.Count)
        {
            Goal goal = _goals[index];
            goal.RecordEvent();
            _score += goal.GetPoints();
            Console.WriteLine($"Congratulations! You have earned {goal.GetPoints()} points.");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"SimpleGoal|{simpleGoal.GetShortName()}|{simpleGoal.GetDescription()}|{simpleGoal.GetPoints()}|{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"EternalGoal|{eternalGoal.GetShortName()}|{eternalGoal.GetDescription()}|{eternalGoal.GetPoints()}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"ChecklistGoal|{checklistGoal.GetShortName()}|{checklistGoal.GetDescription()}|{checklistGoal.GetPoints()}|{checklistGoal.GetTarget()}|{checklistGoal.GetAmountCompleted()}|{checklistGoal.GetBonus()}");
                }
            }
        }
    }
    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    string points = parts[3];

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            simpleGoal.RecordEvent();
                        }
                        _goals.Add(simpleGoal);
                    }
                    else if (type == "EternalGoal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[6]);
                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                        checklistGoal.SetCompleted(int.Parse(parts[5]));
                        _goals.Add(checklistGoal);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}