public class ListingActivity : Activity
{
    private string _name = "Listing Activity";
    private string _description = "This activity will help you reflect on the food things in your life by having you list as many things as you can in a certain area.";
    private List<string> _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];

    public ListingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        DisplayStart(_name, _description);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[random.Next(0, _prompts.Count())]} ---");
        Console.Write("You may begin in: ");
        CountPause(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        do
        {
            currentTime = DateTime.Now;
            Console.ReadLine();
        } while (currentTime < endTime);
        DisplayEnd(_name);
    }
}