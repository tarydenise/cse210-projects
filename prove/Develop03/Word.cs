public class Word
{
    public string _text { get; private set; }
    public bool _isHidden { get; set; }

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
}
