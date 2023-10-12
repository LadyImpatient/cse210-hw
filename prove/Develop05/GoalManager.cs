using System;
using System.IO;

class GoalManager
{
    private Goal[] _goals;
    private int _score;
    private int _goalCount;
    private int _level;

    public GoalManager()
    {
        _goals = new Goal[10];
        _score = 0;
        _goalCount = 0;
        _level = 1;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\nGoal Manager Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    DisplayPlayerInfo();
                    break;
                case 2:
                    ListGoalNames();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    CreateGoal();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score} points");
        Console.WriteLine($"Player's Level: {_level}");
    }

    public void ListGoalNames()
    {
        if (_goalCount == 0)
        {
            Console.WriteLine("No goals created yet.");
        }
        else
        {
            Console.WriteLine("Goal Names:");
            for (int i = 0; i < _goalCount; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
            }
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        for (int i = 0; i < _goalCount; i++)
        {
            Console.WriteLine(_goals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nCreating a new goal:");
        Console.Write("\nEnter goal name: ");
        string name = Console.ReadLine();
        Console.Write("\nEnter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("\nSelect goal type:");
        Console.WriteLine("1. Simple Goal (one-time goal)");
        Console.WriteLine("2. Eternal Goal (ongoing goal that can be completed multiple times)");
        Console.WriteLine("3. Checklist Goal (step-by-step milestone to achieve a progressive goal)");
        Console.Write("Enter goal type (1/2/3): ");
        int goalType = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalType)
        {
            case 1:
                newGoal = new SimpleGoal(name, description);
                break;
            case 2:
                newGoal = new EternalGoal(name, description);
                break;
            case 3:
                Console.Write("Enter goal target: ");
                int target = int.Parse(Console.ReadLine());
                int bonus = 0; // Bonus for Checklist Goal can be set to 0
                newGoal = new ChecklistGoal(name, description, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        _goals[_goalCount] = newGoal;
        _goalCount++;
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        if (_goalCount == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("Select a goal to record an event for:");
        for (int i = 0; i < _goalCount; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }

        Console.Write("Enter the number of the goal to record an event for: ");
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > _goalCount)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal selectedGoal = _goals[goalNumber - 1];

        if (selectedGoal.IsComplete())
        {
            Console.WriteLine("This goal has already been completed.");
        }
        else
        {
            selectedGoal.RecordEvent();
            _score += selectedGoal.Points;

            // Check for level up
            if (_score >= _level * 1000)
            {
                _level++;
                Console.WriteLine($"Level up! You are now at Level {_level}");
            }

            Console.WriteLine($"Event recorded for {selectedGoal.ShortName}. You earned {selectedGoal.Points} points!");
        }
    }
}
