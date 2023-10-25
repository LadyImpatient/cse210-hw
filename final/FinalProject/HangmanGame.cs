using System;

// HangmanGame class for playing Hangman game
class HangmanGame
{
    public void Play()
    {
        Console.WriteLine("Let's play Hangman!");
        Console.Write("Enter the hangman term: ");
        string term = Console.ReadLine().ToLower();
        Console.Write("Enter the definition: ");
        string definition = Console.ReadLine();
        Hangman hangman = new Hangman(term, definition);

        while (!hangman.IsGameOver())
        {
            hangman.DisplayHangman();
            Console.Write("Enter your guess (a single letter): ");
            string guess = Console.ReadLine().ToLower();

            if (guess.Length == 1 && char.IsLetter(guess[0]))
            {
                if (hangman.GuessTerm(guess))
                {
                    Console.WriteLine($"Congratulations! You guessed the term: {hangman.GetTerm()}");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a single letter.");
            }
        }

        if (!hangman.IsGameOver())
        {
            Console.WriteLine("You win!");
        }
        else
        {
            hangman.DisplayHangman();
            Console.WriteLine($"You lost. The correct term was: {hangman.GetTerm()}");
        }
    }
}
