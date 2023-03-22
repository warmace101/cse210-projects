using System;

public class Activity
{
    private string _nameActivity = "";
    private string _descriptionActivity = "";
    private int _durationInSeconds = 0;

    public Activity()
    {

    }
    public Activity(string name, string description)
    {
        _nameActivity = name;
        _descriptionActivity = description;

    }
    public Activity(int duration)
    {
        _durationInSeconds = duration;
    }
    public string DisplayNameActivity()
    {
        Console.Clear();
        return _nameActivity;
    }

    public string DisplayDescriptionActivity()
    {
        return _descriptionActivity;
    }

    public int DisplayDurationActivity()
    {
        return _durationInSeconds;
    }

    public void DisplayStartingMassage()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        //Thread.Sleep(6000);
    }
    public void DisplayEndingMassage()
    {
        int seconds = DisplayDurationActivity();
        Console.WriteLine("Well done!!!");
        ShowSpinnerAnimation();
        Console.WriteLine($"You have completed another {seconds} seconds of Breathing Activity.");
        ShowSpinnerAnimation();
    }

    public void ShowSpinnerAnimation()
    {

        List<String> animations = new List<String>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }


}