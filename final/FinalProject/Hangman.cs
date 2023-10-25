using System;

// Hangman class for playing Hangman game
class Hangman
{
    protected string term; // Change the access modifier to protected
    private string definition;
    private char[] guessedLetters;
    private int guessedLetterCount;
    private int incorrectGuesses;

    public Hangman(string term, string definition)
    {
        this.term = term.ToLower();
        this.definition = definition;
        guessedLetters = new char[26];
        guessedLetterCount = 0;
        incorrectGuesses = 0;
    }

    public bool GuessTerm(string guess)
    {
        guess = guess.ToLower();
        char letter = guess[0];

        if (Array.IndexOf(guessedLetters, letter) == -1)
        {
            guessedLetters[guessedLetterCount] = letter;
            guessedLetterCount++;

            if (CheckGuess())
            {
                return true;
            }
        }
        else
        {
            Console.WriteLine("You've already guessed that letter.");
        }
        return false;
    }

    private bool CheckGuess()
    {
        foreach (char letter in term)
        {
            if (Array.IndexOf(guessedLetters, letter) == -1)
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayHangman()
    {
        // Hangman drawing
        string[] hangmanDrawing =
        {
            "   _____ ",
            "   |   | ",
            $"   {((incorrectGuesses >= 1) ? "O" : " ")}   | ",
            $"  {((incorrectGuesses >= 3) ? "/" : " ")}{((incorrectGuesses >= 2) ? "|" : " ")}{((incorrectGuesses >= 4) ? "\\" : " ")}  | ",
            $"  {((incorrectGuesses >= 5) ? "/" : " ")} {((incorrectGuesses >= 6) ? "\\" : " ")}  | ",
            "       | ",
            "  _____| "
        };

        Console.Clear();
        Console.WriteLine(definition);

        foreach (string line in hangmanDrawing)
        {
            Console.WriteLine(line);
        }
        Console.WriteLine();

        // Display guessed letters
        Console.Write("Guessed Letters: ");
        for (int i = 0; i < guessedLetterCount; i++)
        {
            Console.Write(guessedLetters[i] + " ");
        }
        Console.WriteLine();
    }

    public bool IsGameOver()
    {
        return incorrectGuesses >= 6 || CheckGuess();
    }

    internal object GetTerm()
    {
        throw new NotImplementedException();
    }
}
