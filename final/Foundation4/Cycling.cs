public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }
    public override double CalcDistance()
    {
        return (_speed / 60) * _length;
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