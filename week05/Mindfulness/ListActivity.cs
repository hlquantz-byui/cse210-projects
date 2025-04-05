class ListActivity : Activity
{
    private List<string> _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    private int _entries = 0;
    public ListActivity()
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _name = "List Activity";
    }
    private Random _rng = new Random();
    public override void StartActivity()
    {
        base.StartActivity();
        ListItems();
        EndActivity();
    }

    private void CountDown()
    {
        base.CoundDown();
    }

    private void ListItems()
    {
        string prompt = _prompts[_rng.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} ---");
        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _entries++;
        }
        Console.WriteLine($"You listed {_entries} items!");
    }
}