public class Swimming : Activity
{
    private int _numOfLap;

    public Swimming(string date, double time, int numOfLap) : base(date, time)
    {
        _numOfLap = numOfLap;
    }

    public override double GetDistance()
    {
        return ((_numOfLap * 50) / (1000 * 0.62));
    }
    public override double GetSpeed()
    {
        return (GetDistance() / _time) * 60;
    }
    public override double GetPace()
    {
        return _time / GetDistance();
    }
    public override string GetSummary()
    {
         return $"{_date} Swimming ({_time} min) - Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}