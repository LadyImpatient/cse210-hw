using System;

class GratitudeActivity : Activity
{
    public GratitudeActivity(string name, int duration) : base(name, duration) { }

    public override void PerformActivity()
    {
        Console.WriteLine("Description: This activity will help you focus on the things you are grateful for in your life.");
        Console.WriteLine("Take a moment to reflect on the people, experiences, and things that you appreciate.");

        // Specific instructions for the GratitudeActivity
        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Find a quiet and comfortable place to sit or lie down.");
        Console.WriteLine("2. Close your eyes, take a few deep breaths, and relax your body.");
        Console.WriteLine("3. Begin to think about the people, experiences, and things in your life that you are grateful for.");
        Console.WriteLine("4. Take your time and savor each thought. Feel the gratitude in your heart.");
        Console.WriteLine("5. Try to focus on at least five things you are grateful for.");

        // Questions to prompt reflection
        string[] questions = new string[]
        {
            "1. What is a person in your life that you are grateful for, and why?",
            "2. What is an experience that brought you joy, and how did it make you feel?",
            "3. What are some material things that you appreciate, and how do they enhance your life?",
            "4. What is a personal quality or talent that you are grateful for?",
            "5. Is there a specific moment from your day or week that made you feel thankful?"
        };

        Console.WriteLine("Take your time to answer these questions and reflect on your gratitude.");
        Console.WriteLine("Press Enter to continue to the next question after each reflection.");

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            Console.ReadLine();
        }

        Console.WriteLine("Gratitude activity completed.");
    }
}
