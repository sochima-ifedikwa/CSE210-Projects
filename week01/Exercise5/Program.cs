using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber);


    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number: ");
        int userNumber  = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared  = number * number;
        return numberSquared;
    }

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }
}