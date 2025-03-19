using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine(fraction1.getFractionString());
        Console.WriteLine(fraction1.getDecimalValue());

        Console.WriteLine(fraction2.getFractionString());
        Console.WriteLine(fraction2.getDecimalValue());

        Console.WriteLine(fraction3.getFractionString());
        Console.WriteLine(fraction3.getDecimalValue());
    }
}