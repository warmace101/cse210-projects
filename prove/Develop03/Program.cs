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
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture(string book int chap int verse);

        ScriptureMemorizer scriputreMemorizer = new ScriptureMemorizer(scripture);

        string userInput = "";

        while userInput != "quit" && scriputreMemorizer.hasWordsLeft == true)
        {
            Console.Clear();
            Console.WriteLine(string.Format("{0} {1}", scriptureReference.toString(), scriputreMemorizer.toString()));
            Console.WriteLine();
            Console.ReadLine();
            scriputreMemorizer.removeWordsFromText();

        };

    }
}
