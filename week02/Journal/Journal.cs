using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Journal
{
    private Entry entry = new Entry();
    private List<Entry> entries = new List<Entry> { };

    public Journal() { }

    public void addEntry()
    {
        entries.Add(new Entry());
        entries[entries.Count - 1].setResponse();
    }

    public void displayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.getResponse();
        }
    }

    public void saveJournal()
    {

        string json = JsonSerializer.Serialize(entries);
        File.WriteAllText("journal.json", json);
    }

    public void loadJournal()
    {
        string json = File.ReadAllText("journal.json");
        entries = JsonSerializer.Deserialize<List<Entry>>(json);
    }
}