using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradePerc = Console.ReadLine();
        int number = int.Parse(gradePerc);
        if (number >= 90)
        {
            Console.WriteLine("You got and A! Congrats!!");
        }
        else if (number >= 80 && number <= 89)
        {
            Console.WriteLine("You got a B");
        }
        else if (number >= 70 && number <= 79)
        {
            Console.WriteLine("You got a C");
        }
        else if (number >= 60 && number<= 69)
        {
            Console.WriteLine("You got a D");
        }
        else if (number < 60)
        {
            Console.WriteLine("You failed!");
        }
    }
}