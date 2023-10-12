using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description)
        : base(name, description, 10)
    {
        
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded an event for the goal: {ShortName} (+{Points} points)!");
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"{ShortName}|{Description}|{Points}";
    }
}
