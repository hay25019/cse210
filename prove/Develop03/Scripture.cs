using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

public class Scripture
{
    private List<Word> wordList = [];
    private string stringScripture;
    private Reference scriptureReference;
    private Random random = new Random();
    public Scripture(string reference, string scripture)
    {
        string[] stringList = scripture.Split(" ");
        foreach (string text in stringList)
        {
            Word word = new Word(text);
            wordList.Add(word);
        }
        scriptureReference = new Reference(reference);
    }
    private void MakeStringFromList()
    {
        List<string> stringList = [];
        foreach (Word word in wordList)
        {
            stringList.Add(word.GetVisibleContent());
        }
        stringScripture = string.Join(" ", stringList);
    }
    public void PickRandomWord()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(0, wordList.Count);
            wordList[index].MakeDissapear();
        }
    }
    public bool CheckIsVisible()
    {
        bool visible = true;
        List<Word> visibleWords = [];
        foreach (Word word in wordList)
        {
            if (word.GetIsVisible() == true)
            {
                visibleWords.Add(word);
            }
        }
        if (visibleWords.Count == 0)
        {
            visible = false;
        }
        return visible;
    }
    public void DisplayScripture()
    {
        MakeStringFromList();
        Console.Clear();
        Console.Write($"{scriptureReference.GetReference()} ");
        Console.WriteLine(stringScripture);
        Console.WriteLine("");
    }
}