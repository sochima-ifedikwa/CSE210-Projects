public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    

    public abstract bool IsComplete();

    public virtual int GetPoints()
    {
        return _points;
    }
    

    public virtual string GetDetailsString()
    {
        string checkbox;
        if (IsComplete()){
            checkbox = "[√]";
        }
        else{
            checkbox = "[ ]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}