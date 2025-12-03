using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        EternalGoal eGoal = new EternalGoal("Eternal Goal", "This will never end", 10);
        Console.WriteLine(eGoal.GetGoal());
        eGoal.RecordEvent();
        eGoal.RecordEvent();
        Console.WriteLine(eGoal.GetGoal());
    }
}