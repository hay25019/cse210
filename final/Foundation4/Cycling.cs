public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }
    public override double CalcDistance()
    {
        return (_speed * _length) / 60;
    }
    public override double CalcSpeed()
    {
        return _speed;
    }
    public override double CalcPace()
    {
        return 60 / _speed;
    }
}