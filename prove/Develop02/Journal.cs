using System.IO;

public class Journal
{
    public List<string> _entries = [];

    public void AppendEntry(string entry)
    {
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void LoadJournal()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }
    public void SaveJournal()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}