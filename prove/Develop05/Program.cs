using System;

class Program
{
    static SimpleList simpleGoals = new SimpleList();
    static EternalList eternalGoals = new EternalList();
    static CheckList checklistGoals = new CheckList();
    static void Main(string[] args)
    {
        bool go = true;
        
        while (go == true)
        {
            FullClear();
            ListAll();
            go = false;
        }
    }
    public static void FullClear()
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.Write(new string(' ', Console.BufferWidth * Console.BufferHeight));
        Console.SetCursorPosition(0, 0);
    }
    public static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of your talk? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());
        if (goalType == 1)
        {
            simpleGoals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        if (goalType == 2)
        {
            eternalGoals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            checklistGoals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonus, goalTimes));
        }

    }
    public static void ListAll()
    {
        Console.WriteLine("Simple goals:");
        simpleGoals.ListGoals();
        Console.WriteLine("Eternal goals:");
        eternalGoals.ListGoals();
        Console.WriteLine("Checklist goals:");
        checklistGoals.ListGoals();
    }
}