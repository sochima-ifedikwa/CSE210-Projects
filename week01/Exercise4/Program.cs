using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Transactions;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers  = new List<int>();

        int number = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        Console.WriteLine($"The sum is: {total}");
    }
}