using System.Diagnostics.Contracts;

public class EternalList : List<EternalGoal>
{
    public void ListGoals()
    {
        foreach (EternalGoal goal in this)
        {
            Console.WriteLine(goal.GetGoal());
            Console.WriteLine();
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("e_goals.txt"))
        {
            foreach (EternalGoal goal in this)
            {
                sw.WriteLine($"{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}");
            }
        }
    }
    public void LoadGoals()
    {
        using (StreamReader sr = new StreamReader("e_goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lines = line.Split("|");
                EternalGoal eGoal = new EternalGoal(lines[0], lines[1], int.Parse(lines[2]));
                this.Add(eGoal);
            }
        }
    }
}