using System.Diagnostics.Contracts;

public class GoalList : List<Goal>
{
    public void ListGoals()
    {
        for (int i = 0; i < this.Count(); i++)
        {
            Goal goal = this[i];
            Console.WriteLine($"{i + 1}. {goal.GetGoal()}");
        }
        Console.WriteLine();
        Console.WriteLine($"You have {CalculateScore()} points.");
        Console.WriteLine();
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
        Console.WriteLine($"\nYou now have {CalculateScore()} points.\n");
    }
    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in this)
            {
                sw.WriteLine(goal.GetStringGoal());
            }
        }
    }
    public void ForceSave(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Goal goal in this)
            {
                sw.WriteLine(goal.GetStringGoal());
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
                    SimpleGoal simpleGoal = new SimpleGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]));
                    this.Add(simpleGoal);
                }
                if (lines[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]));
                    this.Add(eternalGoal);
                }
                if (lines[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]), int.Parse(lines[7]), lines[8]);
                    this.Add(checklistGoal);
                }
            }
        }
    
    }public void ForceLoad(string filename)
    {
        using (StreamReader sr = new StreamReader(filename))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lines = line.Split("|");
                if (lines[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]));
                    this.Add(simpleGoal);
                }
                if (lines[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]));
                    this.Add(eternalGoal);
                }
                if (lines[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(int.Parse(lines[1]), lines[2], lines[3], int.Parse(lines[4]), int.Parse(lines[5]), int.Parse(lines[6]), int.Parse(lines[7]), lines[8]);
                    this.Add(checklistGoal);
                }
            }
        }
    }
    public int CalculateScore()
    {
        int score = 0;
        foreach (Goal goal in this)
        {
            score += goal.GetScore();
        }
        return score;
    }
}