using System;

class Program
{
    static void Main(string[] args)
    {
        //Get user's first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Get user's last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Print user's first and last name in the style of Jame Bond.
        Console.WriteLine($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}