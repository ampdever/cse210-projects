public class Entry {
    public string _date;
    public string _promptText;
    public string _entryText;

    public string Display() {
        //Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
        return $"Date: {_date} - Prompt: {_promptText}\n{_entryText}";
    }
    //abstraction baby!!!
}