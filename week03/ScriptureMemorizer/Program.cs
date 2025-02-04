using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = null;
        Scripture scripture = null;

        while(true) {
            Console.Clear();
            Console.Write($"{reference.GetDisplayText()}");
            Console.WriteLine($"{scripture.GetDisplayText()}");

            Console.Write("Press Enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            if (userInput == "quit") {
                break;
            }
            else if (userInput == "") {
                // do nothing
                scripture.HideRandomWords(2);

                if (scripture.IsCompletelyHidden()) {
                    Console.WriteLine("You have fully memorized the scripture! Congratulations!");
                    break;
                }
            }
        }
    }
}