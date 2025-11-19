using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge Him, and He shall direct thy paths.");
        while (true)
        {
            scripture.DisplayScripture();
            if (scripture.CheckIsVisible() == false)
            {
                break;
            }
            Console.WriteLine("Please enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine().ToLower();
            if (answer == "quit")
            {
                break;
            }
            else
            {
                scripture.PickRandomWord();
            }
        }
    }
}