using System;
using System.Formats.Asn1;

class Program
{
    static GoalList goals = new GoalList();
    static void Main(string[] args)
    {
        bool go = true;
        
        while (go == true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            int answer = int.Parse(Console.ReadLine());
            if (answer == 1)
            {
                CreateGoal();
            }
            else if (answer == 2)
            {
                ListAll();
            }
            else if (answer == 3)
            {
                goals.SaveGoals();
            }
            else if (answer == 4)
            {
                goals.LoadGoals();
            }
            else if (answer == 6)
            {
                go = false;
            }
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
            goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
        }
        if (goalType == 2)
        {
            goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
        }
        if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTimes = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());
            goals.Add(new ChecklistGoal(goalName, goalDescription, goalPoints, goalBonus, goalTimes));
        }

    }
    public static void ListAll()
    {
        Console.WriteLine("The goals are:");
        goals.ListGoals();
    }
}