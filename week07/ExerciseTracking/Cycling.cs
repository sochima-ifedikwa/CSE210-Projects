public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _time / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
         return $"{_date} Cycling ({_time} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}