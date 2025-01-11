using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("What is your favorite number? ");
        int userNumber  = int.Parse(Console.ReadLine());

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        Console.Write("What is your number: ");
        number  = int.Parse(Console.ReadLine());

        int numberSquared  = number * number;
        return numberSquared;
    }
}