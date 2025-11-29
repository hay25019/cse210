public class BreathingActivity : Activity
{
    private string _name = "Breathing Activity";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        Console.Clear();
        DisplayStart(_name, _description);
        InOut();
        DisplayEnd(_name);
    }
    public void InOut()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause();
        Console.WriteLine("");
        Console.Write("Breathe in...");
        CountPause(2);
        Console.WriteLine("");
        Console.Write("Now breathe out...");
        CountPause(3);
        Console.WriteLine("");
        for (int i = 0; i < (_duration / 10); i++)
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            CountPause(4);
            Console.WriteLine("");
            Console.Write("Now breathe out...");
            CountPause(6);
            Console.WriteLine("");
        }
    }
}