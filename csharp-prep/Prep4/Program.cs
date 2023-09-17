using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

class Program
{
    static void Main(string[] args)
    {
        //make list
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers (enter 0 when finished)");
        
        while (true)
        {
            //request input number
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0)
                    break;

                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }


        //sum & max
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
        }
        else
        {
            int sum = 0;
            int max = numbers[0];

            foreach (int k in numbers)
            {
                sum += k;
                if (k > max)
                {
                    max = k;
                }
            }
            
            //average
            double average = (double)sum / numbers.Count;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Maximum: {max}");
        }
    }
}