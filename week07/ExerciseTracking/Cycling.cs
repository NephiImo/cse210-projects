public class Cycling : Activity
{
    private double _speed; // in km/h

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * GetLengthInMinutes() / 60; // km
    }

    public override double GetSpeed()
    {
        return _speed; // km/h
    }

    public override double GetPace()
    {
        return 60 / _speed; // min/km
    }
}