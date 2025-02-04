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
        Random random = new Random();
        int x = 0;
        int index;
        while (x < NumberToHide) {
            index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden()) {
                _words[index].Hide();
                x++;
            }
        }
    }

    public string GetDisplayText() 
    {
        List<string> scriptureWords = new List<string>();
        foreach (Word word in _words) 
        {
            scriptureWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", scriptureWords);
    }

    public bool IsCompletelyHidden() 
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}