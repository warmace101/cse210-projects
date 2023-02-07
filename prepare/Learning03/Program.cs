using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTop());
        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetTop());
        Fraction f3 = new Fraction(5, 5);
        Console.WriteLine(f3.GetDecimal());
        Console.WriteLine(f2.GetFraction());
        
    }
}