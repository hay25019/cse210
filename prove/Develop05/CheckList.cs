using System.Diagnostics.Contracts;

public class CheckList : List<ChecklistGoal>
{
    public void ListGoals()
    {
        foreach (ChecklistGoal goal in this)
        {
            Console.WriteLine(goal.GetGoal());
            Console.WriteLine();
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("c_goals.txt"))
        {
            foreach (ChecklistGoal goal in this)
            {
                sw.WriteLine($"{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}|{goal.GetTimesToComplete()}|{goal.GetTimesCompleted()}|{goal.GetBonusValue()}");
            }
        }
    }
    public void LoadGoals()
    {
        using (StreamReader sr = new StreamReader("c_goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lines = line.Split("|");
                ChecklistGoal cGoal = new ChecklistGoal(lines[0], lines[1], int.Parse(lines[2]), int.Parse(lines[5]), int.Parse(lines[3]), int.Parse(lines[4]));
                this.Add(cGoal);
            }
        }
    }
}