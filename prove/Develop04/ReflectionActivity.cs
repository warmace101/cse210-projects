using System;

public class ReflectionActivity : Activity
{
    public int ranNumber = 0;
    public int randNumberQ = 0;
    public List<string> _Prompts = new List<string>();
    public List<string> _Questions = new List<string>();



    public ReflectionActivity()
    {

    }
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }

    public ReflectionActivity(int duration, int num, int num1) : base(duration)
    {
        int _num = num;
        int _num1 = num1;
        RunActivity(duration, _num, _num1);
    }

    public void RunActivity(int duration, int num, int num1)
    {
        _Prompts.Add("Think of a time when you stood up for someone else.");
        _Prompts.Add("Think of a time when you did something really difficult.");
        _Prompts.Add("Think of a time when you helped someone in need.");
        _Prompts.Add("Think of a time when you did something truly selfless.");


        _Questions.Add("Why was this experience meaningful to you?");
        _Questions.Add("Have you ever done anything like this before?");
        _Questions.Add("How did you get started?");
        _Questions.Add("How did you feel when it was complete?");
        _Questions.Add("What made this time different than other times when you were not as successful?");
        _Questions.Add("What is your favorite thing about this experience?");
        _Questions.Add("What could you learn from this experience that applies to other situations?");
        _Questions.Add("What did you learn about yourself through this experience?");
        _Questions.Add("How can you keep this experience in mind in the future?");


        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.Write("  --- ");
        RandomPrompt(num);
        Console.WriteLine(" --- ");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string userInput = Console.ReadLine();
        if (userInput == string.Empty)
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.Clear();
            DateTime start = DateTime.Now;
            DateTime endTime = start.AddSeconds(duration);
            while (DateTime.Now <= endTime)
            {
                Console.Write("> ");
                RandomQuestion(num);
                ShowSpinnerAnimation();
            }
        }
    }

    public void RandomPrompt(int ranNumber)
    {
        Random num = new Random();
        int randNumber = num.Next(0, _Prompts.Count);
        //prompt.ranNumber = randNumber;


        Console.Write((_Prompts[randNumber]));
    }

    public void RandomQuestion(int randNumberQ)
    {
        Random num1 = new Random();
        int ranNumberQ = num1.Next(0, _Questions.Count);
        //questionToReflect.randNumberQ = randNumberQ;

        Console.WriteLine((_Questions[ranNumberQ]));
    }

}