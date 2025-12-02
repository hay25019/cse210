public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        DisplayStart(0);
        InOut();
        DisplayEnd(0);
    }
    public void InOut()
    {
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