public class Scripture {

    public Reference _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text) 
    {
        _reference = Reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words) {
            _words.Add(new Word(word));
            }
    }
    public void HideRandomWords(int NumberToHide) 
    {
        return ;
    }

    public string GetDisplayText() 
    {
        return "Scripture";
    }

    public bool IsCompletelyHidden() {
        return true;
    }
}