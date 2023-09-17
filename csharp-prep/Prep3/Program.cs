using System;

class Program
{
    static void Main(string[] args)
    {
        //random number
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 101);

        int y = -1;

        while (y != x)
            {
                //ask for guess
                Console.WriteLine("What is your guess? ");
                y = int.Parse(Console.ReadLine());
                
                //if statements
                if (y > x)
                    {
                        Console.WriteLine("Lower");
                    }
                else if (y < x)
                    {
                        Console.WriteLine("Higher");
                    }
                else    
                    {
                        Console.WriteLine("You guessed it!");
                    }
            }
    }
}