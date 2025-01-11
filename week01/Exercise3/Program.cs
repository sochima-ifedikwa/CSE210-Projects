using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber = -1;
        Random randomGeneartor = new Random();
        int magicNumber = randomGeneartor.Next(1, 101);
        
        while (guessNumber != magicNumber)
        {
            
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
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