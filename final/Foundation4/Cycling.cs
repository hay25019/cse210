public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
        _activityType = "Cycling";
    }
    public override int CalcDistance()
    {
        return (_speed / 60) * _length;
    }
    public override int CalcSpeed()
    {
        return _speed;
    }
    public override int CalcPace()
    {
        return 60 / _speed;
    }
}