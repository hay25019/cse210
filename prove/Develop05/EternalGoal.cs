public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        _score += _pointValue;
    }
    public EternalGoal(string name, string description, int pointValue) : base(name, description, pointValue)
    {
        
    }
}