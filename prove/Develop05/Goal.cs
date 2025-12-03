using System.Reflection.Metadata;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _pointValue;
    protected bool _completed = false;
    protected int _score;

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
    public bool GetCompleted()
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
        _completed = true;
    }
}