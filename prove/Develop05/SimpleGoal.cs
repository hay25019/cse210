public class SimpleGoal : Goal
{
    public SimpleGoal(int score, string name, string description, int pointValue, string completed) : base(name, description, pointValue, score, completed)
    {
        
    }
    public SimpleGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
    public override string GetStringGoal()
    {
        return $"SimpleGoal|{_score}|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}