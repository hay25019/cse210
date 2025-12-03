using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ChecklistGoal cGoal = new ChecklistGoal("Checklist Goal", "This is a checklist", 10, 50, 3);
        Console.WriteLine(cGoal.GetGoal());
        cGoal.RecordEvent();
        Console.WriteLine(cGoal.GetGoal());
        cGoal.RecordEvent();
        Console.WriteLine(cGoal.GetGoal());
        cGoal.RecordEvent();
        Console.WriteLine(cGoal.GetGoal());
    }
}