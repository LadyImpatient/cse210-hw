using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
}