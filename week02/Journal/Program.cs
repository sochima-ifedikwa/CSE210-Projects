using System;

class Program
{
    static void Main(string[] args)
    {

        Journal theJournal = new Journal(); // Create a new instance of the Journal class
        Entry anEntry = new Entry(); // Create a new instance of the Entry class
        
        

        Console.WriteLine("Welcome to the program!");
        Console.WriteLine("Please select the following choices");
        int choice = -1;
        while (choice != 5)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry entry = new Entry();
                DateTime theCurrentDate = DateTime.Now;
                entry._date = theCurrentDate.ToShortDateString();
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                entry._promptText = prompt;
                Console.WriteLine(prompt);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                theJournal.AddEntry(entry);
            }
            else if (choice == 2)
            {
                theJournal.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
                Console.WriteLine("Success:  journal loaded!");
                
            }
            else if (choice == 4)
            {
                Console.Write("What is the file name? ");
                string file = Console.ReadLine();
                theJournal.SaveTofile(file);
                Console.WriteLine("Success:  journal saved!");
                
            }
        }

    }
}