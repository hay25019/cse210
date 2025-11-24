using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Ammon Hayward", "Programming");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Ammon Hayward", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeWorkList());
    }
}