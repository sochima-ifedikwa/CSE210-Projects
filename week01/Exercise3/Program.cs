using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicNumber  = int.Parse(Console.ReadLine());
        Console.Write("What is your guess? ");
        int guessNumber = int.Parse(Console.ReadLine());

        
        

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