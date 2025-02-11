using System.Dynamic;
using System.Runtime.CompilerServices;

public class Comment {
    private string _textComment;
    private string _commenter;

public Comment(string textComment, string commenter) 
{
    _textComment = textComment;
    _commenter = commenter;
}
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}: {_textComment}");
    }

    public string GetTextComment()
    {
        return _textComment;
    }

    public string GetCommenter()
    {
        return _commenter;
    }
}