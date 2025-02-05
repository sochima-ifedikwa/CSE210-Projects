using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Scripture Memorizer Project.");

        Reference reference = null;
        Scripture scripture = null;

        Console.WriteLine("Do you want a short scripture reference or a long one ? (long/short)");
        string userChoice = Console.ReadLine();

        //creating an instance of a short passage
        Reference shortReference = new Reference("Proverbs", 3, 5);
        Scripture shortScripture = new Scripture(shortReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        // creating an instance of a long passage
        Reference longReference = new Reference("Proverbs", 3, 5, 6);
        Scripture longScripture = new Scripture(longReference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        if (userChoice.ToLower() == "short") {
            reference = shortReference;
            scripture = shortScripture;
        }
        else if (userChoice.ToLower() == "long") {
            reference = longReference;
            scripture = longScripture;
        }

        while (true) {
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayText()}");
            Console.WriteLine($"{scripture.GetDisplayText()}");

            Console.Write("Press enter to continue or type 'q' to quit: ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "q") {
                break;
            }
            else if(userInput == "") {
                scripture.HideRandomWords(2);

                if (scripture.IsCompletelyHidden()) {
                    Console.WriteLine("You have hidden all the words!");
                    break;
                }
            }
        }
    }
}