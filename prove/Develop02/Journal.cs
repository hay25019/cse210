using System.IO;
using System.Text;

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
    public string GetFileExtention(string filename)
    {
        string extention = Path.GetExtension(filename);
        return extention.Substring(1).ToLower();
    }
    public void LoadJournal()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string fileExt = GetFileExtention(filename);
        if (fileExt == "txt")
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                _entries.Add(line);
            }
        }
        else if (fileExt == "csv")
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(",");
                    foreach (string field in fields)
                    {
                        _entries.Add(field);
                    }
                }
            }
        }
        
    }
    public void SaveJournal()
    {
        Console.Write("What is the filename? ");
        string filename = Console.ReadLine();
        string fileExt = GetFileExtention(filename);
        if (fileExt == "txt")
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (string entry in _entries)
                {
                    outputFile.WriteLine(entry);
                }
            }
        }
        else if (fileExt == "csv")
        {
            StringBuilder csvContent = new StringBuilder();
            foreach (string entry in _entries)
            {
                csvContent.AppendLine(entry);
            }
            File.WriteAllText(filename, csvContent.ToString());
        }
        
    }
}