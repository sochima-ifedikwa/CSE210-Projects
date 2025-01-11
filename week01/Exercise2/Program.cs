using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratualations!! You passed.");
        }
        else
        {
            Console.WriteLine("Try again next time.");
        }

        // This is the strectch challenge to the exercise
        string gradeSign  = "";

        int lastDigit  = grade % 10;
        if (lastDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (lastDigit <= 3)
        {
            gradeSign = "-";
        }
    }
}