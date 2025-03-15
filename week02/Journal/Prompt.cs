class Prompt
{
    private List<String> _prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "What was the most difficult challenge you overcame?", "What are you most proud of today?"];
    public Prompt() { }

    public string getPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count)];
    }
}