using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToDisplayString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine("\"Date\",\"Mood\",\"Prompt\",\"Response\"");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        for (int i = 1; i < lines.Length; i++)
        {
            Entry entry = Entry.FromCsv(lines[i]);
            _entries.Add(entry);
        }
    }
}