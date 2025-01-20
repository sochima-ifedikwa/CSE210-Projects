public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the most challenging thing I faced today?",
        "How did I see the hand of the Lord in my life today?",
        "What was the most joyful moment I experienced today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(_prompts.Count);
        return _prompts[number];
    }
}