public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        _score += _pointValue;
    }
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
    public override string GetStringGoal()
    {
        return $"EternalGoal|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}