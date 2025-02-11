using System.Dynamic;
using System.Runtime.CompilerServices;

public class Comment {
    public string _textComment;
    public string _commenter;

public Comment(string commenter, string textComment) 
{
    _textComment = textComment;
    _commenter = commenter;
}
    public void DisplayComment()
    {
        Console.WriteLine($"{_commenter}: {_textComment}");
    }

   
}