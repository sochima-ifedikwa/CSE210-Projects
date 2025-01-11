using System;
using System.Runtime.CompilerServices;
// using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> words = new List<string>();

        words.Add("Phone");
        words.Add("Keyboard");
        words.Add("Mouse");

        Console.WriteLine(words.Count);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


    }
}