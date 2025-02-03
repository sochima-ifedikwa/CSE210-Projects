public class Word {

    private string _text;
    private bool _isHidden;
    public void Hide() 
    {
    }

    public void Show() 
    {
    }

    public bool IsHidden()
    {
        return true;
    }

    public Word(string text)
    {
        _text = text;
    }
    public string GetDisplayText()
    {
        return "";
    }
}