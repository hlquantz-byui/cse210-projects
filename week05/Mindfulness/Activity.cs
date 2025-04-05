using System.Threading;

public class Activity
{
    protected int _duration;
    protected string _description;
    protected string _name;

    public Activity()
    {
    }

    public virtual void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n");
        Console.WriteLine($"{_description}\n");

        do
        {
            Console.Write("How long, in seconds would you like for your session? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int duration))
            {
                _duration = duration;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        } while (true);

        Console.Clear();
        Console.WriteLine("Get ready...");
        Pause();
        Console.WriteLine();
    }

    protected virtual void EndActivity()
    {
        Console.WriteLine("Well done!!\n");
        Pause();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Pause();
        Console.Clear();
    }

    protected void Pause()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

        while (DateTime.Now < endTime)
        {
            ShowAnimation();
        }
        Console.Write(" ");
    }

    private void ShowAnimation()
    {
        string[] spinner = { "\\", "|", "/", "-" };

        foreach (string item in spinner)
        {
            Console.Write(item);
            Thread.Sleep(100);
            Console.CursorLeft = Console.CursorLeft - 1;
        }
    }

    protected void CoundDown(int duration = 5)
    {
        Console.Write(duration);
        int currentCount = duration;

        for (int i = 0; i < duration; i++)
        {
            currentCount -= 1;
            Console.CursorLeft = Console.CursorLeft - 1;
            Console.Write($"{currentCount}");
            Thread.Sleep(1000);
        }

        Console.CursorLeft = Console.CursorLeft - 1;
        Console.Write(" ");
    }
}