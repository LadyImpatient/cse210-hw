using System;
class Activity
{
    protected int duration;
    protected string name;

    public Activity(string name)
    {
        this.name = name;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Console.WriteLine("Press Enter to start.");
        Console.ReadLine();
    }

    public virtual void End()
    {
        Console.WriteLine($"Good job! You have completed the {name} activity.");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }
}