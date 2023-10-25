using System;

class FlashCard
{
    public void AddCustomOrganelle(string name, string function)
    {
        CustomOrganelle organelle = new CustomOrganelle(name, function);
        Console.WriteLine($"Custom organelle '{organelle.Name}' has been added.");
    }

    public void StudyOrganelles()
    {
        Console.WriteLine("Study Organelles (Flashcards):");
        // You can add your flashcard study logic here
    }

    public void ListCustomOrganelles()
    {
        Console.WriteLine("Custom Organelles:");
        // You can list custom organelles here
    }
}
