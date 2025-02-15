using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();
        
        MathAssignment mathAssignment1 = new MathAssignment("Roberto Reodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}