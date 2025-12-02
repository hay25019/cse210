public class ListingActivity : Activity
{
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public ListingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        DisplayStart(2);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(0, _prompts.Count())]} ---");
        Console.Write("You may begin in: ");
        CountPause(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        List<string> answers = [];
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            answers.Add(Console.ReadLine());
        }
        answers.RemoveAll(string.IsNullOrEmpty);
        Console.WriteLine($"You listed {answers.Count()} items!");
        DisplayEnd(2);
    }
}