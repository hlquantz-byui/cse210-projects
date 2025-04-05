using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");
        BreathingActivity breathingActivity = new BreathingActivity();

        ReflectionActivity reflectionActivity = new ReflectionActivity();

        ListActivity listActivity = new ListActivity();

        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a chioce from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                breathingActivity.StartActivity();
            }
            else if (input == "2")
            {
                reflectionActivity.StartActivity();
            }
            else if (input == "3")
            {
                listActivity.StartActivity();
            }
            else if (input == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please select an option from the menu.");
                Thread.Sleep(1000);
                Console.Clear();
            }

        }

    }
}