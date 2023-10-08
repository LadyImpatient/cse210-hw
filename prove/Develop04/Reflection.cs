using System;

class ReflectionActivity : Activity
{
    public ReflectionActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you reflect on times in your life when you have shown strength and resilience.");
    }
}