public abstract class Activity
{
    protected string _date;
    protected double _length;
    protected string _activityType;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }
    public abstract double CalcDistance();
    public abstract double CalcSpeed();
    public abstract double CalcPace();
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityType} ({_length} min)- Distance {CalcDistance():0.0} miles, Speed {CalcSpeed():0.0} mph, Pace: {CalcPace():0.0} min per mile");
    }
}