using System;

class ReflectionActivity : Activity
{
    public ReflectionActivity(string name) : base(name) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Description: This activity will help you reflect on times in your life when you have shown strength and resilience.");
         string[] prompts = new string[]
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string[] questions = new string[]
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new Random();
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt);
            Console.ReadLine();
            foreach (string question in questions)
            {
                Console.WriteLine(question);
                // Pause for reflection, you can use Console.ReadLine or another method if desired
                Console.WriteLine("Press Enter to continue to the next question.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("Reflection activity completed.");
        Console.ReadLine();
    }
}