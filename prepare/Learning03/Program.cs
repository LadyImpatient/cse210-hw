using System;

class Program
{
    static void Main(string[] args)
    {
        class Fraction
            {
                private int top;
                private int bottom;
//no parameters
                public Fraction()
                {
                    top = 1;
                    bottom = 1;
                }
//top
                public Fraction(int numerator)
                {
                    top = numerator;
                    bottom = 1;
                }

                public Fraction(int numerator, int denominator)
                {
                    top = numerator;
                    bottom = denominator;
                }

                public string GetFractionString()
                {
                    Console.WriteLine($"{numerator}/{denominator}");
                }
                public double GetDecimalValue(decimal)
                {
                    double decimal = numerator/denominator;
                    Console.WriteLine(decimal);
                }
            }
    }
}