using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

public class Scripture
{
    private Dictionary<int, Word> wordList = new Dictionary<int, Word>();
    private string stringScripture;
    private Reference scriptureReference;
    private Random random = new Random();
    public Scripture(string reference, string scripture)
    {
        string[] stringList = scripture.Split(" ");
        for (int i = 0; i < stringList.Count(); i++)
        {
            string text = stringList[i];
            Word word = new Word(text);
            wordList.Add(i, word);
        }
        scriptureReference = new Reference(reference);
    }
    private void MakeStringFromList()
    {
        List<string> stringList = [];
        for (int i = 0; i < wordList.Count(); i++)
        {
            Word word = wordList[i];
            stringList.Add(word.GetVisibleContent());
        }
        stringScripture = string.Join(" ", stringList);
    }
    public void PickRandomWord()
    {
        for (int i = 0; i < 3; i++)
        {
            int index;
            while (true)
            {
                index = random.Next(0, wordList.Count);
                if (wordList[index].GetIsVisible() == false)
                {
                    if (CheckIsVisible() == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    break;
                }
                
            }
            wordList[index].MakeDissapear();
        }
    }
    public bool CheckIsVisible()
    {
        bool visible = true;
        List<Word> visibleWords = [];
        for (int i = 0; i < wordList.Count(); i++)
        {
            Word word = wordList[i];
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