public abstract class Activity 
{
    protected string _date;
    protected double _time;
    public Activity(string date, double time){
        _date = date;
        _time = time;

    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetSummary();
}
