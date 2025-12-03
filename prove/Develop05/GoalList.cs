using System.Diagnostics.Contracts;

public class GoalList : List<Goal>
{
    public void ListGoals()
    {
        for (int i = 0; i < this.Count(); i++)
        {
            Goal goal = this[i];
            Console.WriteLine($"{i + 1}. {goal.GetGoal()}");
            Console.WriteLine();
        }
    }
    public void ListRecord()
    {
        for (int i = 0; i < this.Count(); i++)
        {
            Goal goal = this[i];
            if (goal.GetCompleted() != "X")
            {
                Console.WriteLine($"{i + 1}. {goal.GetName()}");
            }
        }
        Console.Write("Which goal did you accomplish? ");
        int goalNum = int.Parse(Console.ReadLine()) - 1;
        this[goalNum].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {this[goalNum].GetPointValue()} points!");
        Console.WriteLine($"\nYou now have {this[goalNum].GetScore()} points.\n");
    }
    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in this)
            {
                sw.WriteLine($"{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}");
            }
        }
    }
    public void LoadGoals()
    {
        using (StreamReader sr = new StreamReader("goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lines = line.Split("|");
                if (lines[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(lines[1], lines[2], int.Parse(lines[3]));
                    this.Add(simpleGoal);
                }
                if (lines[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(lines[1], lines[2], int.Parse(lines[3]));
                    this.Add(eternalGoal);
                }
                if (lines[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(lines[1], lines[2], int.Parse(lines[3]), int.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]), lines[7]);
                    this.Add(checklistGoal);
                }
            }
        }
    }
}