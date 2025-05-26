using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing my constructors
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // // Testing getters/setters
        // f1.SetTop(2);
        // f1.SetBottom(3);
        // Console.WriteLine($"Numerator: {f1.GetTop()}");
        // Console.WriteLine($"Denominator: {f1.GetBottom()}");

        // Testing representations
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}