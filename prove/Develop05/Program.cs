using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleList goals = new SimpleList();
        SimpleGoal sGoal = new SimpleGoal("Simple Goal", "This is a goal", 50);
        SimpleGoal sGoal1 = new SimpleGoal("Simple Goal 1", "This is also a goal", 51);
        EternalGoal eGoal = new EternalGoal("Eternal Goal", "This never ends", 10);
        ChecklistGoal cGoal = new ChecklistGoal("Checklist Goal", "This is a checklist", 10, 50, 3);
        goals.Add(sGoal);
        goals.Add(sGoal1);
        //goals.Add(eGoal);
        //goals.Add(cGoal);
        FullClear();
        goals.ListGoals();
        Console.WriteLine(goals.Count());
        goals.SaveGoals();
    }
    public static void FullClear()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.Write(new string(' ', Console.BufferWidth * Console.BufferHeight));
        Console.SetCursorPosition(0, 0);
    }
}