using System;
using System.Collections.Generic;
using System.IO;

//need to 
class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

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

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
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
                    List<JournalEntry> allEntries = journal.GetAllEntries();
                    Console.WriteLine("Journal Entries:");
                    foreach (var journalEntry in allEntries)
                    {
                        Console.WriteLine(journalEntry);
                    }
                    break;

                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    SaveJournalToFile(journal, saveFileName);
                    Console.WriteLine("Journal saved to the file!\n");
                    break;

                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal = LoadJournalFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from the file!\n");
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("That is currently not an option. Please try again.\n");
                    break;
            }
        }
    }

    static void SaveJournalToFile(Journal journal, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var entry in journal.GetAllEntries())
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    static Journal LoadJournalFromFile(string fileName)
    {
        Journal journal = new Journal();
        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        JournalEntry entry = new JournalEntry(parts[1], parts[2], parts[0]);
                        journal.AddEntry(entry);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        return journal;
    }
}
