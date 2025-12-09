using System.Reflection.Metadata;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected string _completed = " ";
    protected int _score;

    public Goal(string name, string description, int pointValue, int score, string completed)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
        _score = score;
        _completed = completed;
    }
    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }
    public string GetCompleted()
    {
        return _completed;
    }
    public int GetScore()
    {
        return _score;
    }
    public virtual void RecordEvent()
    {
        _score += _pointValue;
        _completed = "X";
    }
    public virtual string GetGoal()
    {
        return $"[{_completed}] {_name} ({_description})";
    }
    public virtual string GetStringGoal()
    {
        return $"Goal|{_score}|{_name}|{_description}|{_pointValue}|{_completed}";
    }
}