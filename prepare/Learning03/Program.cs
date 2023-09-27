using System;

class Program
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(int numerator)
        {
            _top = numerator;
            _bottom = 1;
        }

        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        public string GetFractionString()
        {
            string frac = $"{_top} / {_bottom}";
            return frac;
        }

        public double GetDecimal()
        {
            double deci = (double)_top/_bottom;
            return deci;
        }
    }

    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimal());
    }
}





