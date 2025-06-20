using System;
using System.Collections.Generic;

// Base class
public abstract class Activity
{
    private string _date;
    private int _lengthInMinutes;

    public Activity(string date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    protected int GetLengthInMinutes() => _lengthInMinutes;
    protected string GetDate() => _date;

    // Abstract methods for derived classes to implement
    public abstract double GetDistance();  // in kilometers
    public abstract double GetSpeed();     // in kph
    public abstract double GetPace();      // minutes per km

    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_lengthInMinutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}
