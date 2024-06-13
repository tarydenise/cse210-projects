public class Scripture
{
    public ScriptureReference _reference { get; private set; }
    public string _text { get; private set; }
    private List<string> _hiddenWords { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _text = text;
        _hiddenWords = new List<string>();
    }

    public string GetFullText()
    {
        return $"{_reference.GetFormattedReference()}\n{_text}";
    }

    public bool HideRandomWords(int numWords)
    {
        if (_hiddenWords.Count >= _text.Split().Length)
        {
            return false;
        }

        var random = new Random();
        var words = _text.Split();

        for (int i = 0; i < numWords; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = random.Next(words.Length);
            } while (_hiddenWords.Contains(words[randomIndex]));

            _hiddenWords.Add(words[randomIndex]);
            words[randomIndex] = "[...]";
        }

        _text = string.Join(" ", words);
        return true;
    }

    public bool IsFullyHidden()
    {
        return _hiddenWords.Count == _text.Split().Length;
    }
}
