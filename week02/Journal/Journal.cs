public class Journal
{
    //Member variables
    public List<Entry> _entries = new List<Entry>();

    //Methods
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputJournal = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputJournal.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string fileName)
    {
        string[] lines = File.ReadAllLines(fileName);
        Journal journal = new Journal();
        Entry newEntry = new Entry();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            journal.AddEntry(newEntry);
        }
    }
}