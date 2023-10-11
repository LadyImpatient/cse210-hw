using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformBreathingActivity();
                    break;
                case "2":
                    PerformReflectionActivity();
                    break;
                case "3":
                    PerformListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    static void PerformBreathingActivity()
    {
        Activity breathing = new BreathingActivity("Breathing", 60);
        breathing.Start();
        breathing.PerformActivity();
        breathing.End();
    }

    static void PerformReflectionActivity()
    {
        Activity reflection = new ReflectionActivity("Reflection", 60);
        reflection.Start();
        reflection.PerformActivity();
        reflection.End();
    }

    static void PerformListingActivity()
    {
        Activity listing = new ListingActivity("Listing", 60);
        listing.Start();
        listing.PerformActivity();
        listing.End();
    }
}
