using System;
using System.IO;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your Journal");
   
        //Declare all my variables
        int menuOption = 9; // Setting the variable as a number that's not one through 5
        DateTime myTimeStamp = new DateTime();  //Using the date time class to get the system date
        var JournalEntry = new List<string>();
        

        //consider using a switch instead of if statement
    do{
        Console.WriteLine("Please select an option listed below by the number listed");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        //you need to validate the user entered a number etc.  data scrub
        menuOption = Convert.ToInt32(Console.ReadLine());
        switch(menuOption)
        {
            case 1:
                //this is menu option 1
                //ask a random question
                Console.WriteLine("Please write an entry");
                string questionPrompt = askQuestion();
                Console.WriteLine(questionPrompt); //Display question to user
                string entry = Console.ReadLine(); //Get response from user
                myTimeStamp = DateTime.Now; //Date and time operator wrote their response
                JournalEntry.Add("On " + myTimeStamp.ToString() + " I was prmompted the Question: \r\n" + questionPrompt + "\r\n" + "I responded with : \r\n" + entry + "\r\n");

                break;
            case 2:
                Console.WriteLine("\r\n\r\nAll journal entries.\r\n");
                foreach (var foo in JournalEntry)
                {
                    Console.WriteLine(foo);
                }
            //display
                break;
            case 3:
            // load
                break;
            case 4:
            //save
            
                break;
            case 5:
            //quit
                break;
            default:
                break;
        }
    }while (menuOption != 5);

    //asking a random question
    static string askQuestion()
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,6);
        string myQuestion = "";
        switch (magicNumber)
            {
                case 1:
                myQuestion = "Who was the most interesting person I interacted with today?";
                break;
                case 2:
                myQuestion = "What was the best part of my day?";
                break;
                case 3:
                myQuestion = "How did I see the hand of the Lord in my life today?";
                break;
                case 4:
                myQuestion = "What was the strongest emotion I felt today?";
                break;
                case 5:
                myQuestion = "If I had one thing I could do over today, what would it be?";
                break;


            }
        return myQuestion;
        
    }
    }

}