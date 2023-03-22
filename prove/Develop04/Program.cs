using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        //Console.WriteLine("Hello Develop04 World!");
        BreathingActivity breathing = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectionActivity reflection = new ReflectionActivity($"Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListeningActivity listening = new ListeningActivity("Welcome to the Listen Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        //Adding prompt to the list of prompts
        ReflectionActivity prompt = new ReflectionActivity();
        /*prompt._Prompts.Add("Think of a time when you stood up for someone else.");
        prompt._Prompts.Add("Think of a time when you did something really difficult.");
        prompt._Prompts.Add("Think of a time when you helped someone in need.");
        prompt._Prompts.Add("Think of a time when you did something truly selfless.");*/

        //Adding questions to the list of question to reflect
        ReflectionActivity questionToReflect = new ReflectionActivity();
        /*questionToReflect._Questions.Add("Why was this experience meaningful to you?");
        questionToReflect._Questions.Add("Have you ever done anything like this before?");
        questionToReflect._Questions.Add("How did you get started?");
        questionToReflect._Questions.Add("How did you feel when it was complete?");
        questionToReflect._Questions.Add("What made this time different than other times when you were not as successful?");
        questionToReflect._Questions.Add("What is your favorite thing about this experience?");
        questionToReflect._Questions.Add("What could you learn from this experience that applies to other situations?");
        questionToReflect._Questions.Add("What did you learn about yourself through this experience?");
        questionToReflect._Questions.Add("How can you keep this experience in mind in the future?");*/

        Random ranPrompt = new Random();
        int randNumber = ranPrompt.Next(0, prompt._Prompts.Count);
        prompt.ranNumber = randNumber;

        Random ranQuest = new Random();
        int randNumberQ = ranQuest.Next(0, questionToReflect._Questions.Count);
        questionToReflect.randNumberQ = randNumberQ;

        //Adding a list of prompts to the prompt liste for the listening activity.
        ListeningActivity prompts = new ListeningActivity();
        prompts._Prompts.Add("Who are people that you appreciate?");
        prompts._Prompts.Add("What are personal strengths of yours?");
        prompts._Prompts.Add("Who are people that you have helped this week?");
        prompts._Prompts.Add("When have you felt the Holy Ghost this month?");
        prompts._Prompts.Add("Who are some of your personal heroes?");

        //etting a random numeber of prompts from the list.
        Random listeningQuestion = new Random();
        int listeningQuestionNum = listeningQuestion.Next(0, prompt._Prompts.Count);
        prompts.listeningQuestionNum = listeningQuestionNum;


        //Start the program
        bool menu = true;
        while (menu == true)
        {
            Console.Clear();
            Console.WriteLine("Menu options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listening activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            int userOption = int.Parse(Console.ReadLine());


            Console.WriteLine("");
            switch (userOption)
            {
                case 1:
                    Console.WriteLine(breathing.DisplayNameActivity());
                    Console.WriteLine();
                    Console.WriteLine(breathing.DisplayDescriptionActivity());
                    Console.WriteLine();
                    Console.Write("How long, in seconds, would you like for your sesion: ");
                    int seconds = int.Parse(Console.ReadLine());
                    breathing.DisplayStartingMassage();
                    breathing.ShowSpinnerAnimation();
                    Console.WriteLine();
                    BreathingActivity duration = new BreathingActivity(seconds);
                    break;
                case 2:
                    Console.WriteLine(reflection.DisplayNameActivity());
                    Console.WriteLine();
                    Console.WriteLine(reflection.DisplayDescriptionActivity());
                    Console.WriteLine();
                    Console.Write("How long, in seconds, would you like for your sesion: ");
                    int seconds1 = int.Parse(Console.ReadLine());
                    reflection.DisplayStartingMassage();
                    reflection.ShowSpinnerAnimation();
                    //prompt.RandomPrompt(prompt.ranNumber); 
                    //questionToReflect.RandomQuestion(questionToReflect.randNumberQ);
                    ReflectionActivity duration1 = new ReflectionActivity(seconds1, prompt.ranNumber, questionToReflect.randNumberQ);
                    break;
                case 3:
                    Console.WriteLine(listening.DisplayNameActivity());
                    Console.WriteLine();
                    Console.WriteLine(listening.DisplayDescriptionActivity());
                    Console.WriteLine();
                    Console.Write("How long, in seconds, would you like for your sesion: ");
                    int seconds2 = int.Parse(Console.ReadLine());
                    listening.DisplayStartingMassage();
                    listening.ShowSpinnerAnimation();
                    listening.RunActivity(seconds2, listeningQuestionNum);
                    break;
                case 4:
                    Console.WriteLine("Have a great day!");
                    menu = false;
                    break;
            }
        }
    }
}