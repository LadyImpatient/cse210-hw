using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Hider!");

        Console.Write("Enter the book: ");
        string book = Console.ReadLine();

        Console.Write("Enter the chapter: ");
        int chapter = int.Parse(Console.ReadLine());

        Console.Write("Enter the start verse: ");
        int startVerse = int.Parse(Console.ReadLine());

        Console.Write("Enter the end verse: ");
        int endVerse = int.Parse(Console.ReadLine());

        Reference userReference = new Reference(book, chapter, startVerse, endVerse);

        Console.WriteLine("Enter the scripture text:");
        string scriptureText = Console.ReadLine();

        Scripture userScripture = new Scripture(userReference, scriptureText);

        bool shouldContinue = true;

        while (shouldContinue)
        {
            Console.Clear();
            Console.WriteLine(userScripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide the next word or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
            {
                shouldContinue = false;
            }
            else if (input == "")
            {
                userScripture.HideNextWord();
                if (userScripture.IsCompletelyHidden())
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
