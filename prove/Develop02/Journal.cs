using System.Text;

public class Journal
{
    public List<Entry> _entries = [];

    public void AppendEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.GetEntry());
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
                Entry entry = new Entry(line);
                _entries.Add(entry);
            }
        }
        else if (fileExt == "csv")
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split("|");
                    foreach (string field in fields)
                    {
                        Entry entry = new Entry(field);
                        _entries.Add(entry);
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
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.GetEntry());
                }
            }
        }
        else if (fileExt == "csv")
        {
            StringBuilder csvContent = new StringBuilder();
            foreach (Entry entry in _entries)
            {
                csvContent.AppendLine(entry.GetEntry());
            }
            File.WriteAllText(filename, csvContent.ToString());
        }
        
    }
}