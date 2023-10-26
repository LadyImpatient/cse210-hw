using System;

class Program
{
    static void Main()
    {
        OrganelleList organelleList = new OrganelleList();
        FlashCard flashCard = new FlashCard(organelleList);
        HangmanGame hangmanGame = new HangmanGame(organelleList); // Pass organelleList as an argument
        PracticeTest practiceTest = new PracticeTest(organelleList); // Pass organelleList as an argument

        while (true)
        {
            Console.WriteLine("\n Choose an option:");
            Console.WriteLine("1. Add Custom Organelle");
            Console.WriteLine("2. Study Organelles (Flashcards)");
            Console.WriteLine("3. List Custom Organelles");
            Console.WriteLine("4. Play Hangman");
            Console.WriteLine("5. Take Practice Test");
            Console.WriteLine("6. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    do
                    {
                        Console.Write("Enter organelle name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter organelle function: ");
                        string function = Console.ReadLine();
                        flashCard.AddCustomOrganelle(name, function);
                        Console.WriteLine("Custom organelle added.");
                        Console.WriteLine("Add another custom organelle? (Y/N): ");
                    } while (Console.ReadLine().Trim().Equals("Y", StringComparison.OrdinalIgnoreCase));
                    break;

                case "2":
                    flashCard.StudyOrganelles();
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
