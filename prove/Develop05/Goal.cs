using System;

abstract class Goal
{
    private string _shortName;
    private string _description;
    protected int _points; // Change the access modifier to protected

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string ShortName => _shortName;
    public string Description => _description;
    public int Points => _points;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"[{(_points > 0 ? " " : "X")}] {_shortName}: {_description}";
    }

    public abstract string GetStringRepresentation();
}
