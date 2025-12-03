using System.Diagnostics.Contracts;

public class GoalList : List<Goal>
{
    public void ListGoals()
    {
        foreach (Goal goal in this)
        {
            Console.WriteLine(goal.GetGoal());
            Console.WriteLine();
        }
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