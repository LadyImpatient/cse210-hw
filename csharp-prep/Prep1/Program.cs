using System;

class Program
{
    static void Main(string[] args)
    {
        //Code requests name and introduces the user like James Bond
        Console.WriteLine("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();
        //Your name is lastname, firstname lastname
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}