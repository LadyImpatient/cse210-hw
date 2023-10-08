using System;
class Activity
{
    protected int duration;
    protected string name;

    public Activity(string name, int duration)
    {
        this.name = name;
        this.duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name} activity...");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Console.WriteLine("Press Enter to start.");
        Console.ReadLine();
    }

    public void End()
    {
        Console.WriteLine($"Good job! You have completed the {name} activity.");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Press Enter to continue.");
        Console.ReadLine();
    }

    public virtual void PerformActivity()
    {
        // This method should be overridden by derived activity classes
    }
}