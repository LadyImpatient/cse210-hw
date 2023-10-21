using System;

class Program
{
    static void Main()
    {
        FlashCard flashCard = new FlashCard();
        HangmanGame hangmanGame = new HangmanGame();
        PracticeTest practiceTest = new PracticeTest();

        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Study Organelles (Flashcards)");
            Console.WriteLine("2. Add Custom Organelle");
            Console.WriteLine("3. List Custom Organelles");
            Console.WriteLine("4. Play Hangman");
            Console.WriteLine("5. Take Practice Test");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    flashCard.StudyOrganelles();
                    break;

                case "2":
                    Console.Write("Enter organelle name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter organelle function: ");
                    string function = Console.ReadLine();
                    flashCard.AddCustomOrganelle(name, function);
                    break;

                case "3":
                    flashCard.ListCustomOrganelles();
                    break;

                case "4":
                    hangmanGame.Play();
                    break;

                case "5":
                    practiceTest.StartTest();
                    break;

                case "6":
                    Console.WriteLine("Exiting the program.");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
