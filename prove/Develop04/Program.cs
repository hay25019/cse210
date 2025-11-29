using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        bool go = true;
        while (go == true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                breathingActivity.RunActivity();
            }
            else if (answer == "2")
            {
                reflectionActivity.RunActivity();
            }
            else if (answer == "3")
            {
                listingActivity.RunActivity();
            }
            else
            {
                go = false;
            }
        }
    }
}