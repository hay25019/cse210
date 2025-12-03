public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
    public override string GetStringGoal()
    {
        return $"SimpleGoal|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}