using Learning04;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assign1 = new Assignment();
        assign1.SetStudentName("John");
        assign1.SetTopic("Coding");
        Console.WriteLine(assign1.GetSummary());
        MathAssignment assign2 = new MathAssignment();
        assign2.SetStudentName("Sariah");
        assign2.SetTopic("Math");
        assign2.SetTextBook("Geometry");
        assign2.SetProblem("Chapter 4 Question 3");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());
    }
}