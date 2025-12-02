using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();
        Dictionary<string, int> activities = new Dictionary<string, int>()
        {
            {"Breathing", 0},
            {"Reflection", 0},
            {"Listing", 0}
        };
        bool go = true;
        Console.Clear();
        while (go == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Activity logs");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string answer = Console.ReadLine();
            if (answer == "1")
            {
                activities["Breathing"] += 1;
                breathingActivity.RunActivity();
                Console.Clear();
            }
            else if (answer == "2")
            {
                activities["Reflection"] += 1;
                reflectionActivity.RunActivity();
                Console.Clear();
            }
            else if (answer == "3")
            {
                activities["Listing"] += 1;
                listingActivity.RunActivity();
                Console.Clear();
            }
            else if (answer == "4")
            {
                foreach (KeyValuePair<string, int> kvp in activities)
                {
                    Console.WriteLine($"Activity: {kvp.Key}, Times done: {kvp.Value}");
                }
            }
            else if (answer == "5")
            {
                go = false;
            }
            else
            {
                Console.Clear();
            }
        }
    }
}