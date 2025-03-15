using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Please select one fo the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            char firstChoice = choice[0];
            if (firstChoice == '1')
            {
                journal.addEntry();
            }
            else if (firstChoice == '2')
            {
                journal.displayEntries();
            }
            else if (firstChoice == '3')
            {
                journal.loadJournal();
            }
            else if (firstChoice == '4')
            {
                journal.saveJournal();
            }
            else if (firstChoice == '5')
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again (1-5).");
            }
        } while (true);
    }
}