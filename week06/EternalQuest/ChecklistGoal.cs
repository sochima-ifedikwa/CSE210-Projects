public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private string _bonus;


    public ChecklistGoal(string name, string description, string points, int target, string bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_shortName} {_description} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}