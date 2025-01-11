using System;
using System.Data.SqlTypes;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        string input = Console.ReadLine();
        int magicNumber  = int.Parse(input);
    }
}