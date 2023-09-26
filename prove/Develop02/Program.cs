using System;
using System.Collections.Generic;

class JournalEntry
{
    public string Prompt;
    public string Response;
    public string Date;

    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Date}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }
}

class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public List<JournalEntry> GetAllEntries()
    {
        return entries;
    }

    public void ClearEntries()
    {
        entries.Clear();
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var journalEntry in entries)
        {
            Console.WriteLine(journalEntry);
        }
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Random random = new Random();
        List<string> prompts = new List<string>
        {
            "What happened today?",
            "What was the most interesting thing you saw or heard?",
            "What are you grateful for today?",
            "What did you do today that you're proud of?",
            "If you had three wishes what would you wish for? Why?"
        };

        bool exit = false; // Flag to control program exit

        while (!exit)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = prompts[random.Next(prompts.Count)];
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    JournalEntry entry = new JournalEntry(randomPrompt, response, date);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry saved!\n");
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    exit = true; // Set the exit flag to true to exit the loop
                    break;

                default:
                    Console.WriteLine("That is currently not an option. Please try again.\n");
                    break;
            }
        }
    }
}
