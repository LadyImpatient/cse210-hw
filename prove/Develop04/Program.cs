using System;

class Program
{
    static void Main()
    {
        Activity breathing = new BreathingActivity("Breathing", 300);
        Activity reflection = new ReflectionActivity("Reflection", 300);
        Activity listing = new ListingActivity("Listing");

        breathing.Start();
        breathing.PerformActivity();
        breathing.End();

        reflection.Start();
        reflection.PerformActivity();
        reflection.End();

        listing.Start();
        listing.PerformActivity();
        listing.End();
    }
}