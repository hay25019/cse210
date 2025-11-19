using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private List<Word> wordList;
    private Random random = new Random();
    public Scripture(string scripture)
    {
        string[] stringList = scripture.Split(" ");
        foreach (string text in stringList)
        {
            Word word = new Word(text);
            wordList.Add(word);
        }
    }
    public void PickRandomWord()
    {
        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(0, wordList.Count);
            wordList[index].MakeDissapear();
            wordList.Remove(wordList[index]);
        }
        

    }
}