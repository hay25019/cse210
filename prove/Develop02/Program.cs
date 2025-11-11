using System;

class Program
{
    static void Main(string[] args)
    {
        bool go = true;
        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string reply = Console.ReadLine();
            if (reply == "1")
            {
                Entry entry = new Entry();
                entry.GetUserInput();
            }
            else if (reply == "5")
            {
                go = false;
            }
        } while (go == true);
    }
}