using System;

class ListingActivity : Activity
{
    public ListingActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("Press Enter to begin.");
        Console.ReadLine();

        string[] prompts = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Console.ReadLine();
            Console.WriteLine("You have 10 seconds to think and list as many items as you can.");
            Countdown(10);
        }

        Console.WriteLine("Listing activity completed.");
        Console.ReadLine();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time left: {i} seconds");
            Wait(1);
        }
    }

    private void Wait(int seconds)
    {
        DateTime start = DateTime.Now;
        while ((DateTime.Now - start).TotalSeconds < seconds) { }
    }
}