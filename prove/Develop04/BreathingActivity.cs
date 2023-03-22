using System;

public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public BreathingActivity(int duration) : base(duration)
    {
        RunActivity(duration);
    }
    public void RunActivity(int duration)
    {
        DateTime start = DateTime.Now;
        DateTime endTime = start.AddSeconds(duration);

        while (DateTime.Now <= endTime)
        {
            BreathIn();
            BreathOut();
            Console.WriteLine();
        }
        DisplayEndingMassage();
    }
    public void BreathIn()
    {
        Console.Write("Breath in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void BreathOut()
    {
        Console.Write("Breath out...");
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}