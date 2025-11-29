public class Activity
{
    protected int _duration;

    public Activity(){

    }
    public void DisplayStart(string name, string description)
    {
        Console.WriteLine($"Welcome to the {name}.");
        Console.WriteLine("");
        Console.WriteLine($"{description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
    }
    protected void SpinnerPause()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i != 0)
            {
                Console.Write("\b");
            }
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(500);
        }
        Console.Write("\b ");
    }
    public void CountPause(int length)
    {
        int number = length;
        for (int i = 0; i < length; i++)
        {
            if (i != 0)
            {
                Console.Write("\b");
            }
            Console.Write(number);
            Thread.Sleep(1000);
            number--;
        }
        Console.Write("\b ");
    }
    public void DisplayEnd(string name)
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {name}");
    }
}