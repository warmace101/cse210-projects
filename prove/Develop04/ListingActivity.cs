using System;

public class ListeningActivity : Activity
{

    public int numOfItems = 0;
    public int listeningQuestionNum = 1;
    public List<string> _Prompts = new List<string>();

    public ListeningActivity()
    {

    }

    public ListeningActivity(string name, string description) : base(name, description)
    {

    }

    public ListeningActivity(int duration, int num) : base(duration)
    {

        RunActivity(duration, num);

    }

    public void RunActivity(int duration, int num)
    {
        _Prompts.Add("Think of a time when you stood up for someone else.");
        _Prompts.Add("Think of a time when you did something really difficult.");
        _Prompts.Add("Think of a time when you helped someone in need.");
        _Prompts.Add("Think of a time when you did something truly selfless.");


        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.Write("  --- ");
        RandomPromptListening(num);
        Console.WriteLine(" --- ");
        Console.Write("You may begin in: ");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(duration);
        while (DateTime.Now <= endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            numOfItems += 1;
        }
        Console.WriteLine($"You listed {numOfItems} items!");
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        ShowSpinnerAnimation();
        Console.WriteLine($"You have completed another {duration} seconds of Listening Activity.");
        ShowSpinnerAnimation();
    }

    public void RandomPromptListening(int listeningQuestionNum)
    {
        Console.WriteLine(_Prompts[listeningQuestionNum]);
    }
}