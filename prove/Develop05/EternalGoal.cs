public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        _score += _pointValue;
    }
    public EternalGoal(int score, string name, string description, int pointValue, string completed) : base(name, description, pointValue, score, completed)
    {
        
    }
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
    public override string GetStringGoal()
    {
        return $"EternalGoal|{_score}|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}