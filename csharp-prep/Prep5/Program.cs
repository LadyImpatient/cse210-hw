using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, number, square);

        //welcome function
        static void DisplayWelcome()
            {
               Console.WriteLine("Welcome to the program!"); 
            }
        //name function
        static string PromptUserName()
            {
                Console.WriteLine("Enter your name:");
                string name = Console.ReadLine();
                return name;
            }
        //number function
        static int PromptUserNumber()
            {
                Console.WriteLine("What is your favorite number? ");
                int number = int.Parse(Console.ReadLine());
                return number;
            }
        //square function
        static int SquareNumber(int number)
            {
                int square = number * number;
                return square;
            }
        //print results
        static void DisplayResult(string name, int number, int square)
            {
                Console.WriteLine($"{name}, the square of your number is {square}.");
            }
    }
}