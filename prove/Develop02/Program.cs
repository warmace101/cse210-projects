using System;

class program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your Journal");
        Console.WriteLine("Please select an option listed below by the number listed");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        //you need to validate the user entered a number etc.  data scrub
        int menuOption = Convert.ToInt32(Console.ReadLine());

        //consider using a switch instead of if statement

        switch(menuOption)
        {
            case 1:
                //this is menu option 1
                //ask a random question
                Console.WriteLine("Please write an entry");
                string foo = askQuestion();
                Console.WriteLine(foo);
                string entry = Console.ReadLine();
                break;
            case 2:
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
//found an easier way to get these options selected
/*
        if (menuOption == 1)
        {
            //Change to a function

        }
        else if (menuOption == 2)
        {

        }
        if (menuOption == 2)
        {
            //change to function
            Console.WriteLine("Display messages");
        }

        if (menuOption == 3)
        {
            Console.WriteLine("loading");
        }

        if (menuOption == 4)
        {
            Console.WriteLine("Save");
        }

        else
        {
            Console.WriteLine("quiting");
        }
        */
        
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