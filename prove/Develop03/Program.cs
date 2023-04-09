/*
Johnathan Wayne Babber's Man
27Feb23 CSE210 Project #3
Functional requirements
Your program must do the following:

Store a scripture, including both the reference (for example "John 3:16") and the text of the scripture.
Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
Clear the console screen and display the complete scripture, including the reference and the text.
Prompt the user to press the enter key or type quit.
If the user types quit, the program should end.
If the user presses the enter key (without typing quit), the program should hide a few random words in the scripture, clear the console screen, and display the scripture again.
The program should continue prompting the user and hiding more words until all words in the scripture are hidden.
When all words in the scripture are hidden, the program should end.
When selecting the random words to hide, for the core requirements, you can select any word at random, even if the word was already hidden. (As a stretch challenge, try to randomly select from only those words that are not already hidden.)
Design Requirements
In addition your program must:

Use the principles of Encapsulation, including proper use of classes, methods, public/private access modifiers, and follow good style throughout.
Contain at least 3 classes in addition to the Program class.
Provide multiple constructors for the scripture reference to handle the case of a single verse and a verse range ("Proverbs 3:5" or "Proverbs 3:5-6").
Showing Creativity and Exceeding Requirements
Meeting the core requirements makes your program eligible to receive a 93%. To receive 100% on the assignment, you need to show creativity and exceed these requirements.

Here are some ideas you might consider:

Think of other challenges that people find when trying to memorize a scripture. Find a way to have your program help with these challenges.
Have your program work with a library of scriptures rather than a single one. Choose scriptures at random to present to the user.
Have the program to load scriptures from a files.
Anything else you can think of!
Report on what you have done to exceed requirements by adding a description of it in a comment in the Program.cs file.
 */

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Load Book Of Mormon text from a file
        LoadFromFile myFile = new LoadFromFile();
        string[] parsedBom = myFile.getParsedBom();
        //Load the text into scripture class
        Scripture[] allScriptures = new Scripture[parsedBom.Length];
        int scripCount = 0;
        foreach (string i in parsedBom)
        {
            string[] chapVers = i.Split(':');
            Array.Resize(ref chapVers, 3); //I only want the first two : in the string.  Some versus have ":" in the text.
            allScriptures[scripCount] = new Scripture(chapVers[0], Convert.ToInt32(chapVers[1]), chapVers[2].Substring(0,chapVers[2].IndexOf(" ")), chapVers[2].Substring(chapVers[2].IndexOf(" ")).Trim());//this is a little confusing.  The last part removes the verse number from the actual verse string.
            scripCount = scripCount + 1;
        }
        bool continueApp = true;
        do
        {
            Console.Clear();
            Menu();
            string strSelection = Console.ReadLine();
            switch (strSelection)
            {
                case "1":
                    Console.Clear();
                    runTextHidder(allScriptures);
                    break;
                case "4"://exit app
                    continueApp = false;
                    break;
                default:
                    Console.WriteLine("That option isn't supported, please select again.");
                    break;

            }

        }while(continueApp);
        Console.WriteLine("Thanks for playing and have a great day!");



    }

    static void runTextHidder(Scripture[] allScripts)
    {
        Console.WriteLine("Please enter a scrupture from the Book Of Mormon you want to master.");
        Console.WriteLine("Use this format to enter in the verse 1 Nephi:1:1 please note the : is important");
        Console.WriteLine("If you enter an incorrect scripture you will get 1 Nephi:1:1, because every has that memorized!!");
        string newScripture = Console.ReadLine();

        int intScripLocation = 0;
        //look for my scripture in the loaded scriptures
        for (int i = 0; i < allScripts.Length; i++)
        {
            string newStr = allScripts[i].GetBook() + ":" + allScripts[i].GetChapter().ToString() + ":" + allScripts[i].GetVersNum();
            if (newStr == newScripture)
            {
                intScripLocation = i;
                break;
            }
        }

        
        Console.WriteLine("\r\n\r\n");
        StringHider myTestString = new StringHider(allScripts[intScripLocation].GetVerse());
        
        string strResponse = "Y";
        while (strResponse != "N" && strResponse != "n") //catch upper and lower case use
        {
            Console.Clear();
            Console.WriteLine("One of the words has been hidden\r\n\r\n");
            myTestString.hideThemWords();
            
            myTestString.listOutWords();
            if (myTestString.AllDoneCheck())
            {
                Console.WriteLine("All of the words have been hidden, thanks for playing!");
                strResponse = "N";
            }
            else
            {
                Console.WriteLine("\r\n\r\nWould you like to hide another word?");
                Console.WriteLine("Continue = Y, Exit = N");
                strResponse = Console.ReadLine().Trim();
            }

        }
    }

    static void Menu()
    {
        //Display a menu to the user
        Console.WriteLine("Welcome the the scripture memorizer app!");
        Console.WriteLine("Please select from the following options.");
        Console.WriteLine("1.  Master scriptures from the Book Of Mormon.");
        //Console.WriteLine("2.  Master scriptures from the Old Testiment.");//future feature
        //Console.WriteLine("3.  Master scriptures from the New Testiment.");//future feature
        Console.WriteLine("4.  Exit the Scriptures Mastery App.");

    }
}
