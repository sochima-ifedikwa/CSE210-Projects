using System.Dynamic;

public class Video {
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _listOfComments;

    public Video(string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
        _listOfComments = new List<Comment>();
    }

    public string VideoDetail() {
        return $"Title: {_title}, Author: {_author}, Length: {_length} minutes";
    }


    public void AddComment(Comment comment) 
    {
        _listOfComments.Add(comment);
    }
    public int GetNumberOfComment() 
    {
        return _listOfComments.Count;
    }
}