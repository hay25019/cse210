public class Word
{
    private string wordContent;
    private string hiddenContent;
    private string visibleContent;
    private bool isVisible = true;

    public Word(string text)
    {
        wordContent = text;
        hiddenContent = new string('*', text.Length);
        visibleContent = wordContent;
    }
    public void MakeDissapear()
    {
        isVisible = false;
        visibleContent = hiddenContent;
    }
    public string GetVisibleContent()
    {
        return visibleContent;
    }
    public bool GetIsVisible()
    {
        return isVisible;
    }
}