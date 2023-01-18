using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eneter a number for the list.  Once you are done entering numbers please press 0.");
        string userInput = Console.ReadLine();
        int number = Convert.ToInt32(userInput);
        int sum = number;
        List<int> myNumb;
        myNumb = new List<int>();
        myNumb.Add(number);
        while (number != 0)
        {
            Console.WriteLine("Enter another number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                myNumb.Add(number);
                sum = sum + number;

            }

        }
    Console.WriteLine("The sum is " + sum.ToString());

   if (sum != 0)//Removing divide by 0
   { 
        double avg = (double)sum / myNumb.Count;
        Console.WriteLine($"The avereage is {avg}");
   }
    Console.WriteLine($"The max value is {myNumb.Max()}");
    Console.WriteLine($"The count is {myNumb.Count}");
    Console.WriteLine("Thanks for playing");



    }
}