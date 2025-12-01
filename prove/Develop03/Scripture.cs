using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

public class Scripture
{
    private Dictionary<int, Word> _wordList = new Dictionary<int, Word>();
    private string _stringScripture;
    private Reference _scriptureReference;
    private Random _random = new Random();
    public Scripture(string reference, string scripture)
    {
        string[] _stringList = scripture.Split(" ");
        for (int i = 0; i < _stringList.Count(); i++)
        {
            string text = _stringList[i];
            Word _word = new Word(text);
            _wordList.Add(i, _word);
        }
        _scriptureReference = new Reference(reference);
    }
    private void MakeStringFromList()
    {
        List<string> _stringList = [];
        for (int i = 0; i < _wordList.Count(); i++)
        {
            Word _word = _wordList[i];
            _stringList.Add(_word.GetVisibleContent());
        }
        _stringScripture = string.Join(" ", _stringList);
    }
    public void PickRandomWord()
    {
        for (int i = 0; i < 3; i++)
        {
            int _index;
            while (true)
            {
                _index = _random.Next(0, _wordList.Count);
                if (_wordList[_index].GetIsVisible() == false)
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
            _wordList[_index].MakeDissapear();
        }
    }
    public bool CheckIsVisible()
    {
        bool _visible = true;
        List<Word> _visibleWords = [];
        for (int i = 0; i < _wordList.Count(); i++)
        {
            Word _word = _wordList[i];
            if (_word.GetIsVisible() == true)
            {
                _visibleWords.Add(_word);
            }
        }
        if (_visibleWords.Count == 0)
        {
            _visible = false;
        }
        return _visible;
    }
    public void DisplayScripture()
    {
        MakeStringFromList();
        Console.Clear();
        Console.Write($"{_scriptureReference.GetReference()} ");
        Console.WriteLine(_stringScripture);
        Console.WriteLine("");
    }
}