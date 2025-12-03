using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        SimpleGoal sGoal = new SimpleGoal("Simple Goal", "This is a goal", 50);
        Console.WriteLine(sGoal.GetGoal());
        sGoal.RecordEvent();
        Console.WriteLine(sGoal.GetGoal());
    }
}