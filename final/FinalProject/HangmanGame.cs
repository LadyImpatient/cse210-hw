using System;

class HangmanGame
{
    private OrganelleList organelleList;

    public HangmanGame(OrganelleList organelleList)
    {
        this.organelleList = organelleList;
    }

    public void Play()
    {
        Console.WriteLine("Let's play Hangman!");

        Organelle[] customOrganelles = organelleList.GetOrganelles();

        if (customOrganelles.Length == 0)
        {
            Console.WriteLine("No custom organelles added. Please add organelles before playing Hangman.");
            return;
        }

        // Randomly select an organelle to play Hangman with
        Random random = new Random();
        int randomIndex = random.Next(customOrganelles.Length);
        CustomOrganelle organelleToGuess = customOrganelles[randomIndex] as CustomOrganelle;

        string termToGuess = organelleToGuess.Name.ToLower();
        string definition = organelleToGuess.Function;

        Hangman hangman = new Hangman(termToGuess, definition);

        while (!hangman.IsGameOver())
        {
            hangman.DisplayHangman();
            Console.Write($"Organelle Function: {definition}\n");
            Console.Write("Guess the organelle name: ");
            string guess = Console.ReadLine().ToLower();

            if (hangman.GuessTerm(guess))
            {
                Console.WriteLine($"Congratulations! You guessed the organelle name: {hangman.GetTerm()}");
                break;
            }
        }

        if (hangman.IsGameOver() && !hangman.IsGuessed())
        {
            hangman.DisplayHangman();
            Console.WriteLine($"You lost. The correct organelle name was: {hangman.GetTerm()}");
        }
        else
        {
            Console.WriteLine("You win!");
        }
    }
}
