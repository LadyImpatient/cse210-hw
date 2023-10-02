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
                Console.WriteLine("Enter the number of words to hide:");
                if (int.TryParse(Console.ReadLine(), out int numberToHide))
                {
                    scripture.HideRandomWords(numberToHide);
                    if (scripture.IsCompletelyHidden())
                    {
                        Console.Clear();
                        Console.WriteLine("Congratulations! You've hidden all the words.");
                        shouldContinue = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
