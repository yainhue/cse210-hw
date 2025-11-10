using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Console.WriteLine("Creating fractions...");
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(6, 7);

        Console.WriteLine("Getting fraction 3");
        frac3.GetTop();
        frac3.GetBottom();

        Console.WriteLine("Setting fraction 1");
        frac1.SetTop(3);
        frac1.SetBottom(4);

        Console.WriteLine("GetFractionString 2");
        Console.WriteLine(frac2.GetFractionString());

        Console.WriteLine("GetDecimalvalue 1,2,3");
        Console.WriteLine(frac1.GetDecimalvalue());
        Console.WriteLine(frac2.GetDecimalvalue());
        Console.WriteLine(frac3.GetDecimalvalue());

    }
}