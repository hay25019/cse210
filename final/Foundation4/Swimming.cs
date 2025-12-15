public class Swimming : Activity
{
    private int _numLaps;

    public Swimming(string date, int length, int numLaps) : base(date, length)
    {
        _numLaps = numLaps;
        _activityType = "Swimming";
    }
    public override double CalcDistance()
    {
        return _numLaps * 50 / 1000 * 0.62;
    }
    public override double CalcSpeed()
    {
        return (CalcDistance() / _length) * 60;
    }
    public override double CalcPace()
    {
        return _length / CalcDistance();
    }
}