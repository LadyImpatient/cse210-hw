using System;

class Program
{
    static void Main()
    {
        Activity breathing = new BreathingActivity("Breathing");
        Activity reflection = new ReflectionActivity("Reflection");
        Activity listing = new ListingActivity("Listing");

        breathing.Start();
        // Perform the breathing activity

        reflection.Start();
        // Perform the reflection activity

        listing.Start();
        // Perform the listing activity

        // End activities
        breathing.End();
        reflection.End();
        listing.End();
    }
}
