public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
    private List<string> _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };

    private Queue<string> _promptQueue;
    private Queue<string> _questionQueue;

    public ReflectionActivity()
    {
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _name = "Reflection Activity";
        _promptQueue = new Queue<string>(ShuffleList(_prompts));
        _questionQueue = new Queue<string>(ShuffleList(_questions));
    }

    public override void StartActivity()
    {
        base.StartActivity();
        ShowPrompt();
        EndActivity();
    }

    private void ShowPrompt()
    {
        if (_promptQueue.Count == 0)
        {
            _promptQueue = new Queue<string>(ShuffleList(_prompts));
        }

        string prompt = _promptQueue.Dequeue();
        Console.WriteLine("Consider the following prmpt:\n");
        Console.WriteLine($" --- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        CountDown();
        Console.Clear();
        AskQuestions();
    }

    private void AskQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        string question;

        while (DateTime.Now < endTime)
        {
            if (_questionQueue.Count == 0)
            {
                _questionQueue = new Queue<string>(ShuffleList(_questions));
            }
            question = _questionQueue.Dequeue();
            Console.Write($"> {question} ");
            Pause();
            Console.WriteLine();
        }

        Console.WriteLine();

    }

    private List<string> ShuffleList(List<string> list)
    {
        Random rng = new Random();
        return list.OrderBy(x => rng.Next()).ToList();
    }

    private void CountDown()
    {
        base.CoundDown();
    }
}