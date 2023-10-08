using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.");     
        
        int durationInSeconds = duration;
        while (durationInSeconds > 0)
        {
            Console.WriteLine("Breathe in...");
            Wait(3);

            Console.WriteLine("Breathe out...");
            Wait(3);

            durationInSeconds -= 6;
        }

        Console.WriteLine("Breathing activity completed.");
        Console.ReadLine();
    }
    private void Wait(int seconds)
    {
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < seconds) { }
    }
}