using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        double squareRoot = SquareRootNumber(userNumber);
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(name, squaredNumber, squareRoot);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name here:");
        string name = Console.ReadLine();
    
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number here:");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static Double SquareRootNumber(int number)
    {
        Double squareRoot = Math.Sqrt(number);
        return squareRoot;
    }
    static void DisplayResult(string name, int square, double squareRoot)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"The square root of your number is: {squareRoot}");
    }
}