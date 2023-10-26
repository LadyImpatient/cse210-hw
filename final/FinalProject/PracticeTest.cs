class PracticeTest
{
    private OrganelleList organelleList;

    public PracticeTest(OrganelleList organelleList)
    {
        this.organelleList = organelleList;
    }

    public void StartTest()
    {
        Console.WriteLine("Welcome to the Organelle Practice Test!");

        Organelle[] customOrganelles = organelleList.GetOrganelles();

        if (customOrganelles.Length == 0)
        {
            Console.WriteLine("No custom organelles added. Please add organelles before taking the practice test.");
            return;
        }

        int score = 0;
        int totalQuestions = customOrganelles.Length;

        foreach (Organelle organelle in customOrganelles)
        {
            Console.Clear();
            Console.WriteLine("Question:");
            Console.WriteLine(organelle.GetFunction());

            Console.WriteLine("Options:");
            List<string> options = GenerateOptions(organelle, customOrganelles);

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
        Console.WriteLine($"Your score: {score} out of {totalQuestions}");
    }

    private List<string> GenerateOptions(Organelle organelle, Organelle[] allOrganelles)
    {
        List<string> options = new List<string>();

        options.Add(organelle.GetName());

        while (options.Count < 4)
        {
            int randomIndex = new Random().Next(allOrganelles.Length);
            Organelle randomOrganelle = allOrganelles[randomIndex];
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
