public class Question{
        
    //public string _myQuestion;

    public Question()
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
    Console.WriteLine(myQuestion);
    }

    };