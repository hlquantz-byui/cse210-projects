using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        string userInput;
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine(scripture.GetDisplayText());

        do
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            Console.Clear();
            scripture.HideRandomWords(2);
            Console.WriteLine(scripture.GetDisplayText());
        } while (!scripture.IsCompletelyHidden());
    }
}