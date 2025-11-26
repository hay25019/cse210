public class Activity
{
    protected int _duration;
    public void DisplayStart(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine("");
        Console.WriteLine($"{description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
    }
    public void SpinnerPause()
    {
        for (int i = 0; i < 3; i++)
        {
            if (i != 0)
            {
                Console.Write("\b \b");
            }
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
        }
    }
}