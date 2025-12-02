public class Activity
{
    protected int _duration;
    protected Random random = new Random();
    private List<string> _names = ["Breathing Activity", "Reflection Activity", "Listing Activity"];
    private List<string> _descriptions = ["This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "This activity will help you reflect on the food things in your life by having you list as many things as you can in a certain area."];

    public Activity(){

    }
    public void DisplayStart(int index)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_names[index]}.");
        Console.WriteLine("");
        Console.WriteLine($"{_descriptions[index]}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like your session? ");
        int.TryParse(Console.ReadLine(), out _duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        SpinnerPause(1);
    }
    protected void SpinnerPause(int length)
    {
        for (int i = 0; i < length; i++)
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
    public void DisplayEnd(int index)
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_names[index]}");
        Thread.Sleep(3000);
    }
}