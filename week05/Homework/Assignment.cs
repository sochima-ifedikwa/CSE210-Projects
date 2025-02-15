public class Assignment
{
    private string _studentName;
    private string _topic;

    
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public void SetStudentName(string studentName)
    {
        _studentName = studentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName}: {_topic}";
    }
}