public class ChecklistGoal : Goal
{
    private int _timesToComplete;
    private int _bonusValue;
    private int _timesCompleted;
    public ChecklistGoal(int score, string name, string description, int pointValue, int bonusValue, int timesToComplete, int timesCompleted, string completed) : base(name, description, pointValue, score)
    {
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _completed = completed;
    }
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int timesToComplete, int timesCompleted, string completed) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _completed = completed;
    }
    public ChecklistGoal(string name, string description, int pointValue, int bonusValue, int timesToComplete) : base(name, description, pointValue)
    {
        _bonusValue = bonusValue;
        _timesToComplete = timesToComplete;
    }
    public override void RecordEvent()
    {
        if (_timesCompleted == _timesToComplete)
        {
            _pointValue += _bonusValue;
            _completed = "X";
        }
        _score += _pointValue;
        _timesCompleted++;
    }
    public override string GetGoal()
    {
        return $"[{_completed}] {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesToComplete}";
    }
    public override string GetStringGoal()
    {
        return $"ChecklistGoal|{_score}{_name}|{_description}|{_pointValue}|{_bonusValue}|{_timesToComplete}|{_timesCompleted}|{_completed}";
    }
    public int GetTimesToComplete()
    {
        return _timesToComplete;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public int GetBonusValue()
    {
        return _bonusValue;
    }
}