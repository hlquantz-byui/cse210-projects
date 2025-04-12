using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager goalManager = new GoalManager();
        string input;

        do
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            Console.Write("Select a choice from the menu: ");

            input = Console.ReadLine();

            if (input == "1")
            {
                goalManager.CreateGoal();
            }
            else if (input == "2")
            {
                goalManager.ListGoals();
            }
            else if (input == "3")
            {
                goalManager.SaveGoals();
            }
            else if (input == "4")
            {
                goalManager.LoadGoals();
            }
            else if (input == "5")
            {
                goalManager.RecordEvent();
            }
            else if (input == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        } while (true);
    }
}