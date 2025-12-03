using System.Diagnostics.Contracts;

public class SimpleList : List<SimpleGoal>
{
    public void ListGoals()
    {
        foreach (SimpleGoal goal in this)
        {
            Console.WriteLine(goal.GetGoal());
            Console.WriteLine();
        }
    }
    public void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("s_goals.txt"))
        {
            foreach (SimpleGoal goal in this)
            {
                sw.WriteLine($"{goal.GetName()}|{goal.GetDescription()}|{goal.GetPointValue()}");
            }
        }
    }
    public void LoadGoals()
    {
        using (StreamReader sr = new StreamReader("s_goals.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                String[] lines = line.Split("|");
                SimpleGoal sGoal = new SimpleGoal(lines[0], lines[1], int.Parse(lines[2]));
                this.Add(sGoal);
            }
        }
    }
}