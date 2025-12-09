public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }
    public void Start()
    {
        int selection = 0;
        while (selection != 6)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Please choose one of the following:\n1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            string input = Console.ReadLine();
            selection = int.Parse(input);

            if (selection == 6)
            {
                break;
            }
            else if (selection == 1)
            {
                CreateGoals();
            }
            else if (selection == 2)
            {
                ListGoalDetails();
                Console.WriteLine();
                Console.WriteLine("Press enter to go back to the menu.");
                Console.ReadLine();
            }
            else if (selection == 3)
            {
                SaveGoals();
            }
            else if (selection == 4)
            {
                LoadGoals();

            }
            else if (selection == 5)
            {
                RecordEvent();

            }

            else
            {
                Console.WriteLine("Invalid selection, please try again.");
                Thread.Sleep(2000);
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points!");
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        int accumulator = 1;
        foreach (var g in _goals)
        {
            Console.WriteLine($"  {accumulator}. {g.GetName()}");
            accumulator += 1;
        }
    }
    public void ListGoalDetails()
    {
        Console.Clear();
        Console.WriteLine("The goals are:");
        int accumulator = 1;
        foreach (var g in _goals)
        {
            Console.WriteLine($"  {accumulator}. {g.GetDetailsString()}");
            accumulator += 1;
        }
    }
    public void CreateGoals()
    {
        Console.Clear();
        Console.WriteLine("The types of goals are:");
        Console.WriteLine($"  1. Simple Goal");
        Console.WriteLine($"  2. Eternal Goal");
        Console.WriteLine($"  3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        string input = Console.ReadLine();
        int selection = int.Parse(input);

        if (selection == 1)
        {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description for your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            string entry = Console.ReadLine();
            int points = int.Parse(entry);
            SimpleGoal newgoal = new SimpleGoal(name, description, points);
            _goals.Add(newgoal);
            Console.WriteLine("Goal succesfuly created!");
        }
        if (selection == 2)
        {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description for your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            string entry = Console.ReadLine();
            int points = int.Parse(entry);
            EternalGoal newgoal = new EternalGoal(name, description, points);
            _goals.Add(newgoal);
            Console.WriteLine("Goal succesfuly created!");
        }
        if (selection == 3)
        {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description for your goal?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal");
            string entry = Console.ReadLine();
            int points = int.Parse(entry);
            Console.WriteLine("How many times does this goal need to be acomplished for a bonus?");
            string entry2 = Console.ReadLine();
            int range = int.Parse(entry2);
            Console.WriteLine("What is the bonus for acomplishing it that many times?");
            string entry3 = Console.ReadLine();
            int bonus = int.Parse(entry3);
            ChecklistGoal newgoal = new ChecklistGoal(name, description, points, range, bonus);
            _goals.Add(newgoal);
            Console.WriteLine("Goal succesfuly created!");
        }
        Console.WriteLine();
        Console.WriteLine("Press enter to go back to the menu.");
        Console.ReadLine();
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.WriteLine();
        Console.WriteLine("Which goal did you accomplish?");
        string input = Console.ReadLine();
        int selection = int.Parse(input);
        _goals[selection - 1].RecordEvent();

        // add points to _score
        if (_goals[selection - 1] is SimpleGoal || _goals[selection - 1] is EternalGoal)
        {
            int points = _goals[selection - 1].GetPoints();
            _score += points;
            _goals[selection - 1].SetPoints(0);
        }
        else if (_goals[selection - 1] is ChecklistGoal cg)
        {
            if (!cg.IsComplete())
            {
                int points = cg.GetPoints();
                _score += points;
            }
            else
            {
                int points = cg.GetBonus();
                _score += points;
                cg.SetPoints(0);
                cg.SetBonus(0);
            }

        }


        Console.WriteLine($"Goal '{_goals[selection - 1].GetName()}' succesfuly recorded");
        Console.WriteLine();
        Console.WriteLine("Press enter to go back to the menu.");
        Console.ReadLine();
    }
    public void SaveGoals()
    {
        Console.Clear();
        Console.WriteLine("Please enter a name for your file (no file extension requiered): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputfile = new StreamWriter($"{fileName}.csv"))
        {
            outputfile.WriteLine($"{_score}");
            foreach (var g in _goals)
            {
                outputfile.WriteLine($"{g.GetStringRepresentation()}");
            }
        }
        Console.WriteLine($"Saved correctly to '{fileName}.csv'!");
        Console.WriteLine();
        Console.WriteLine("Press enter to go back to the menu.");
        Console.ReadLine();
    }
    public void LoadGoals()
    {
        Console.Clear();
        // 
        Console.WriteLine("Please enter the name of your file (no file extension requiered): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.csv");
        _goals.Clear();

        //skip the header (first line)
        string newScore = lines[0];

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            // _shortName|_description|_points|_isComplete|_bonus|_target|_amountCompleted

            // saves each part of each line in a variable
            string type = parts[0];
            string shortName = parts[1];
            string description = parts[2];
            string points = parts[3];
            string isComplete = parts[4];
            string bonus = parts[5];
            string target = parts[6];
            string amountCompleted = parts[7];

            if (type == "SimpleGoal:")
            {
                SimpleGoal newGoal = new SimpleGoal(shortName, description, int.Parse(points));
                if (isComplete == "True")
                {
                    newGoal.SetStatus(true);
                }
                else if (isComplete == "False")
                {
                    newGoal.SetStatus(false);
                }

                _goals.Add(newGoal);

            }
            else if (type == "EternalGoal:")
            {
                EternalGoal newGoal = new EternalGoal(shortName, description, int.Parse(points));
                newGoal.SetAmountCompleted(int.Parse(amountCompleted));

                _goals.Add(newGoal);
            }

            else if (type == "ChecklistGoal:")
            {
                ChecklistGoal newGoal = new ChecklistGoal(shortName, description, int.Parse(points), int.Parse(target), int.Parse(bonus));
                newGoal.SetAmountCompleted(int.Parse(amountCompleted));

                _goals.Add(newGoal);
            }
        }
        _score = int.Parse(newScore);
        Console.WriteLine($"Loaded correctly from '{fileName}.csv'!");
        Console.WriteLine("");
    }
}



