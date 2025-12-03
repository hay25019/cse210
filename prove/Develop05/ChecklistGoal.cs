public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _bonusValue;
    private int _timesCompleted;
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int timesToComplete) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;
    }
    public override void RecordEvent()
    {
        _score += _pointValue;
        _timesCompleted++;
        if (_timesCompleted == _timesToComplete)
        {
            _score += _bonusValue;
            _completed = "X";
        }
    }
}