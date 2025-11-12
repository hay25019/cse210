public class Entry
{
    public List<string> _prompts = ["What was your favorite thing today?", "What do you wish you could do-over from today?", "How many people did you serve today?", "What are some blessings you got today?", "How many times did you compliment someone?"];

    public string GetUserInput()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        DateTime currentDay = DateTime.Now;
        string dateText = currentDay.ToShortDateString();
        return $"Date: {dateText} - Prompt: {prompt} {Environment.NewLine} {response}";
    }
}