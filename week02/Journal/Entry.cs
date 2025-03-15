class Entry
{
    public String Response { get; set; }
    public DateTime Today { get; set; }
    public String CurrentPrompt { get; set; }
    private readonly Prompt _prompt = new Prompt();
    public Entry() { }

    public void setResponse()
    {
        CurrentPrompt = _prompt.getPrompt();
        Console.WriteLine(CurrentPrompt);
        Console.Write(">");
        Response = Console.ReadLine();
        Today = DateTime.Now;
    }

    public void getResponse()
    {
        Console.WriteLine($"Date: {Today.ToString("M/d/yyy")} - Prompt: {CurrentPrompt}");
        Console.WriteLine($"{Response}");
    }
}