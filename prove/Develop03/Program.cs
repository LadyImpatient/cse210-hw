using System;

class Program

{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Enter the scripture reference (e.g., John 3:16): ");
        string referenceText = Console.ReadLine();

        Console.WriteLine("Enter the scripture text: ");
        string scriptureText = Console.ReadLine();

        Reference reference = new Reference(referenceText);
        Scripture scripture = new Scripture(reference, scriptureText);

        bool shouldContinue = true;

        while (shouldContinue)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                shouldContinue = false;
            }
            else
            {
                scripture.HideRandomWords(3); // Hide 3 random words
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations! You've hidden all the words.");
                    shouldContinue = false;
                }
            }
        }

        Console.WriteLine("Goodbye!");
    }
}