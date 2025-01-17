public class Job
{   
    // member variables(attributes) 
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = -1;
    public int _endYear = -1;

    // A Constructor is made for the Job class
    public Job()
    {
    }

    // member methods (functions)
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}