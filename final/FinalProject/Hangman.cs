class Hangman
{
    private string term;
    private string definition;
    private char[] correctGuesses;
    private int correctGuessCount;
    private char[] incorrectGuesses;
    private int incorrectGuessCount;
    private int maxIncorrectGuesses = 6;
    private bool isGuessed;

    public Hangman(string term, string definition)
    {
        this.term = term.ToLower();
        this.definition = definition;
        correctGuesses = new char[26];
        correctGuessCount = 0;
        incorrectGuesses = new char[maxIncorrectGuesses];
        incorrectGuessCount = 0;
        isGuessed = false;
    }

    public bool GuessTerm(string guess)
    {
        guess = guess.ToLower();

        if (guess == term)
        {
            isGuessed = true;
            return true;
        }

        char letter = guess[0];

        if (Array.IndexOf(correctGuesses, letter) == -1 && Array.IndexOf(incorrectGuesses, letter) == -1)
        {
            if (term.Contains(letter))
            {
                correctGuesses[correctGuessCount] = letter;
                correctGuessCount++;
            }
            else
            {
                incorrectGuesses[incorrectGuessCount] = letter;
                incorrectGuessCount++;
            }
        }
        else
        {
            Console.WriteLine("You've already guessed that letter.");
        }

        isGuessed = CheckGuess();
        return isGuessed;
    }

    public bool IsGuessed()
    {
        return isGuessed;
    }

    private bool CheckGuess()
    {
        foreach (char letter in term)
        {
            if (Array.IndexOf(correctGuesses, letter) == -1)
            {
                return false;
            }
        }
        isGuessed = true;
        return true;
    }

    public void DisplayHangman()
    {
        // Hangman drawing stages
        string[] hangmanDrawing =
        {
            "   _____ ",
            "   |   | ",
            $"   {((incorrectGuessCount >= 1) ? "O" : " ")}   | ",
            $"  {((incorrectGuessCount >= 3) ? "/" : " ")}{((incorrectGuessCount >= 2) ? "|" : " ")}{((incorrectGuessCount >= 4) ? "\\" : " ")}  | ",
            $"  {((incorrectGuessCount >= 5) ? "/" : " ")} {((incorrectGuessCount >= 6) ? "\\" : " ")}  | ",
            "       | ",
            "  _____| "
        };

        Console.Clear();
        Console.WriteLine($"Organelle Function: {definition}");

        for (int i = 0; i <= incorrectGuessCount && i < hangmanDrawing.Length; i++)
        {
            Console.WriteLine(hangmanDrawing[i]);
        }
        Console.WriteLine();

        // Display guessed letters
        Console.Write("Correct Letters: ");
        for (int i = 0; i < correctGuessCount; i++)
        {
            Console.Write(correctGuesses[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Incorrect Letters: ");
        for (int i = 0; i < incorrectGuessCount; i++)
        {
            Console.Write(incorrectGuesses[i] + " ");
        }
        Console.WriteLine();
    }

    public bool IsGameOver()
    {
        return incorrectGuessCount >= maxIncorrectGuesses || isGuessed;
    }

    public string GetTerm()
    {
        return term;
    }
}
