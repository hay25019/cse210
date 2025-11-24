using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ammon Hayward", "Programming");
        Console.WriteLine(assignment.GetSummary());
    }
}