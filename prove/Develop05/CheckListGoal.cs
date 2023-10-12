class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int target, int bonus)
        : base(name, description, 100)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }


    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"You completed the goal: {ShortName} (+{Points} points)!");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"You've reached the target for {ShortName} and earned a bonus of +{_bonus} points!");
                _points += _bonus;
            }
        }
    }


    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return $"[{_amountCompleted}/{_target}] {ShortName}: {Description}";
    }

    public void LoadAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}|{Description}|{Points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}
