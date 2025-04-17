public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;
    
    public Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public abstract double GetDistance();  // in km
    public abstract double GetSpeed();  // in km/h
    public abstract double GetPace();   // in min/km

    public virtual string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }
}