using System.IO;
public class File {
    public List<Entry> _entries = new();

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }
    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            Console.WriteLine(entry.Display());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file) {
        //saving to file goes here
        using (StreamWriter outputFile = new StreamWriter(file)) {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
            }
        }
    }

    public void LoadFromFile(string file) {
    //     string[] lines = File.ReadAllLines(file);
    //     Entry ent = new();
    //     for (int num = 0; num < lines.Length(); num++) {
    //         ent._date = lines[num];
    //         num++;
    //         ent._promptText = lines[num];
    //         num++;
    //         ent._entryText = lines[num];
    //     }
    }
}