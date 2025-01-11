using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int magicNumber  = int.Parse(input);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        
        

        while (guessNumber != magicNumber)
        {
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}