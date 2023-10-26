using System;
using System.Collections.Generic;

class FlashCard
{
    private OrganelleList organelleList;
    private List<Organelle> shuffledOrganelles;
    private Random random = new Random();
    private int currentFlashcardIndex = 0;

    public FlashCard(OrganelleList organelleList)
    {
        this.organelleList = organelleList;
    }

    public void StudyOrganelles()
    {
        Console.WriteLine("Study Organelles (Flashcards):");

        Organelle[] customOrganelles = organelleList.GetOrganelles();
        if (customOrganelles.Length == 0)
        {
            Console.WriteLine("No custom organelles added.");
            return;
        }

        shuffledOrganelles = ShuffleOrganelles(customOrganelles);

        while (true)
        {
            Organelle currentOrganelle = shuffledOrganelles[currentFlashcardIndex];
            DisplayFlashcard(currentOrganelle);
            Console.WriteLine("Press Enter for the next flashcard, or type 'exit' to return to the main menu...");
            string input = Console.ReadLine().ToLower();

            if (input == "exit")
            {
                return;
            }
            else if (input == "")
            {
                currentFlashcardIndex = (currentFlashcardIndex + 1) % shuffledOrganelles.Count;
                Console.Clear();
            }
        }
    }

    private void DisplayFlashcard(Organelle organelle)
    {
        Console.WriteLine("╔══════════════════════════════════╗");
        Console.WriteLine("║        Organelle Flashcard       ║");
        Console.WriteLine("╟──────────────────────────────────╢");
        Console.WriteLine($"║ Name: {organelle.Name,-26} ║");
        Console.WriteLine("╟──────────────────────────────────╢");
        Console.WriteLine($"║ Function: {organelle.Function,-22} ║");
        Console.WriteLine("╚══════════════════════════════════╝");
    }

    public void AddCustomOrganelle(string name, string function)
    {
        CustomOrganelle organelle = new CustomOrganelle(name, function);
        organelleList.AddOrganelle(organelle);
        Console.WriteLine($"Custom organelle '{organelle.Name}' has been added.");
    }

    public void ListCustomOrganelles()
    {
        Organelle[] customOrganelles = organelleList.GetOrganelles();

        if (customOrganelles.Length == 0)
        {
            Console.WriteLine("Custom Organelles: None added yet.");
        }
        else
        {
            Console.WriteLine("Custom Organelles:");
            foreach (Organelle organelle in customOrganelles)
            {
                Console.WriteLine(organelle.GetInfo());
            }
        }
    }

    private List<Organelle> ShuffleOrganelles(Organelle[] organelles)
    {
        List<Organelle> shuffled = new List<Organelle>(organelles);
        int n = shuffled.Count;
        while (n > 1)
        {
            n--;
            int k = random.Next(n + 1);
            Organelle value = shuffled[k];
            shuffled[k] = shuffled[n];
            shuffled[n] = value;
        }
        return shuffled;
    }
}
