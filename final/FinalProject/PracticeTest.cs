using System;

class PracticeTest
{
    private List<Organelle> organelles;

    public PracticeTest()
    {
        organelles = new List<Organelle>();
    }

    public void AddOrganelle(Organelle organelle)
    {
        organelles.Add(organelle);
    }

    public void StartTest()
    {
        Console.WriteLine("Welcome to the Organelle Practice Test!");

        int score = 0;

        foreach (Organelle organelle in organelles)
        {
            Console.Clear();
            Console.WriteLine("Question:");
            Console.WriteLine(organelle.GetFunction());

            Console.WriteLine("Options:");
            List<string> options = GenerateOptions(organelle);

            for (int i = 0; i < options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.Write("Your answer (1-4): ");
            if (int.TryParse(Console.ReadLine(), out int answer) && answer >= 1 && answer <= 4)
            {
                if (options[answer - 1] == organelle.GetName())
                {
                    Console.WriteLine("Correct!");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect. The correct answer is: {organelle.GetName()}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose a number from 1 to 4.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Test Completed!");
        Console.WriteLine($"Your score: {score} out of {organelles.Count}");
    }

    private List<string> GenerateOptions(Organelle organelle)
    {
        List<string> options = new List<string>();

        options.Add(organelle.GetName());

        while (options.Count < 4)
        {
            int randomIndex = new Random().Next(organelles.Count);
            Organelle randomOrganelle = organelles[randomIndex];
            if (!options.Contains(randomOrganelle.GetName()))
            {
                options.Add(randomOrganelle.GetName());
            }
        }

        Shuffle(options);

        return options;
    }

    private void Shuffle<T>(IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = new Random().Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
