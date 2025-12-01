public class Word
{
    private string _wordContent;
    private string _hiddenContent;
    private string _visibleContent;
    private bool _isVisible = true;

    public Word(string text)
    {
        _wordContent = text;
        _hiddenContent = new string('-', text.Length);
        _visibleContent = _wordContent;
    }
    public void MakeDissapear()
    {
        _isVisible = false;
        _visibleContent = _hiddenContent;
    }
    public string GetVisibleContent()
    {
        return _visibleContent;
    }
    public bool GetIsVisible()
    {
        return _isVisible;
    }
}