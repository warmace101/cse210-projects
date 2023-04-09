// See https://aka.ms/new-console-template for more information
/* 
John Babb
2Feb2023
Unit 02 Develop: Journal Program
Functional Requirements
This program must contain the following features:

Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
Display the journal - Iterate through all entries in the journal and display them to the screen.
Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
Provide a menu that allows the user choose these options
Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
Who was the most interesting person I interacted with today?
What was the best part of my day?

How did I see the hand of the Lord in my life today?
What was the strongest emotion I felt today?
If I had one thing I could do over today, what would it be?
Your interface should generally follow the pattern shown in the video demo below.

I will be using the these Classes for my requirements.
* DateTime
* File
* StreamReader
* StreamWriter
* List
* Console
* 
My dad helped me with my code.  He helped me as I was doing it and tutored me on the things that I was getting confused on.
 */

using System;
using System.IO;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your Journal");

        //Declare all my variables
        int menuOption = 0; 
        DateTime myTimeStamp = new DateTime();  //Using the date time class to get the system date.
        var JournalEntry = new List<string>();  //Using the List class to store journal entries.
        string myPath = PromptUserForJournal(); //Ask the user to select a Journal to load on startup.
        JournalEntry = readJournal(myPath);

        //Do while will always execute at least one time
        do
        {
            //Could move this to a function call
            Console.WriteLine("\r\n\r\nPlease select an option listed below by the number listed");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            //you need to validate the user entered a number etc.  data scrubing
            try
            {
                menuOption = Convert.ToInt32(Console.ReadLine()); //if user enters anything but integer you will get an error
            }
            catch
            {
                Console.WriteLine("The program did not understand your selection, please try again");
            }

            switch (menuOption)
            {
                case 1:
                    //Add new journal entry
                    Console.WriteLine("Please write an entry");
                    Question questionPrompt = new Question();  //ask a random question using the question class that was made
                    
                    Console.WriteLine(questionPrompt); //Display question to user
                    string entry = Console.ReadLine(); //Get response from user
                    myTimeStamp = DateTime.Now; //Date and time operator wrote their response
                    JournalEntry.Add("On " + myTimeStamp.ToString() + " I was prmompted the Question: \r\n" + questionPrompt + "\r\n" + "I responded with : \r\n" + entry + "\r\n");
                    Console.Clear(); // clear at end so user can see the question.
                    break;
                case 2:
                    //display
                    Console.Clear(); //clear at start to make it easier to read many entries.
                    Console.WriteLine("\r\n\r\nAll journal entries.\r\n");
                    foreach (var strEntry in JournalEntry)
                    {
                        Console.WriteLine(strEntry);
                    }
                    
                    break;
                case 3:
                    // load
                    Console.Clear();
                    myPath = PromptUserForJournal();
                    JournalEntry = readJournal(myPath);
                    
                    break;
                case 4:
                    //save
                    Console.Clear();
                    myPath = PromptUserForJournal();
                    saveJournal(JournalEntry, myPath);
                    break;
                case 5:
                    //quit
                    //ask if the user wants to save journal before exiting?
                    Console.Clear();
                    saveJournal(JournalEntry, myPath); //Save journal on exit
                    
                    break;
                default:
                    Console.WriteLine("You entered a number that is not a option on the menu, please try again");
                    break;
            }
            
        } while (menuOption != 5);
/*
        //asking a random question
        static string askQuestion()
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 6);
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
*/
        //Save to file
        static void saveJournal(List<string> JE,string mp)
        {
            if (File.Exists(mp)) //make sure we have a file to load
            {
                //File exists, do nothing
            }
            else
            {
                FileStream fs = File.Create(mp);//create file.  Need to find a way to release as this will break the program when ran. 
                fs.Close();// creating a new file leaves it open.  If you don't close it the streamwriter will fail.

            }

            StreamWriter sw = new StreamWriter(mp);  //Using StreamWriter class to write journal to a file

            foreach (var strEntry in JE)
            {
                sw.WriteLine(strEntry);//Write journal data to file
            }
            sw.Close();

            Console.WriteLine("Journal has been saved to disk.");
        }

        //Read from file
        static List<string> readJournal(string mp)
        {
            var JournalEntry = new List<string>();  //Using the List class to store journal entries.
            if (File.Exists(mp)) //make sure we have a file to load
            {
                StreamReader sr = File.OpenText(mp);  //Using StreamReader class to read my saved journal
                string strJournal = "";
                while ((strJournal = sr.ReadLine()) != null)
                {
                    JournalEntry.Add(strJournal);
                }
                sr.Close();
                Console.WriteLine("Journal has been loaded from disk.");
            }
            else
            {
                Console.WriteLine("There is no Journal file to load.");
            }
            return JournalEntry;
        }

         static string PromptUserForJournal()
        {
            //Get our current path
            string myPath = Directory.GetCurrentDirectory();
            string[] filePaths = Directory.GetFiles(myPath, "*.txt");
            Console.WriteLine("Please enter the journal file you would like to load or type a new file name to save.");
            foreach (string s in filePaths)
            {
                string fn = Path.GetFileName(s);    
                Console.WriteLine(fn);
            }
            //need to add some data scrubbing here.  It is case sensitive.
            string userSelection = Console.ReadLine();
            bool matchFound = false;
            foreach (string s in filePaths)
            {
                string fn = Path.GetFileName(s);
                Console.WriteLine("Filename: " + fn.ToString() + "   User entered: " + userSelection);
                if (fn == userSelection)
                {
                    //we have a match.
                    Console.WriteLine("Loading journal " + fn.ToString());
                    matchFound = true;  
                    break;
                }
                else
                {
                    //Console.WriteLine("Your entry doesn't match any available journals.");
                }
            }
            if (!matchFound)
            {
                userSelection = "Journal.txt"; //Default to Journal.txt if the operator messes up?
            }
            return userSelection;
        }
 
    }

};

