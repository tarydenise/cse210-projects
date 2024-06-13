public class ScriptureReference
{
    public string _book { get; private set; }
    public int _startChapter { get; private set; }
    public int? _endChapter { get; private set; }

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(':');
        _book = parts[0].Trim();

        string chapterVerse = parts[1].Trim();
        string[] chapterVerseParts = chapterVerse.Split('-');

        _startChapter = int.Parse(chapterVerseParts[0]);
        _endChapter = chapterVerseParts.Length > 1 ? int.Parse(chapterVerseParts[1]) : (int?)null;
    }

    public string GetFormattedReference()
    {
        return _endChapter.HasValue ? $"{_book} {_startChapter}:{_endChapter}" : $"{_book} {_startChapter}";
    }
}
