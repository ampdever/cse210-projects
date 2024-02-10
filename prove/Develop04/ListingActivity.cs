public class ListingActivity : Activity {
    private int _count = 0;
    private List<string> _prompts;

    public ListingActivity(string name, string desc, int dur, List<string> prompts) 
        : base (name, desc, dur) {
            _prompts = prompts;
    }

    public void Run() {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (DateTime.Now < futureTime) {
            Console.Write("You may begin in...");
            for (int i = 5; i >= 1; i--) {
                Console.Write($"\rYou may begin in...{i}");
                Thread.Sleep(1000);
            }
        }
        Console.Write("\b \b");
        Console.WriteLine("\n");

        Console.WriteLine();
        DateTime startTimeTwo = DateTime.Now;
        DateTime futureTimeTwo = startTime.AddSeconds(getDuration());
        while(DateTime.Now < futureTimeTwo) {
            Console.Write("> ");
            string input = Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You've listed {_count} items!");
        Thread.Sleep(4000);
    }

    public string GetRandomPrompt() {
        Random rand = new();
        int num = rand.Next(0, _prompts.Count());
        return $"{_prompts[num]}";
    }

    public List<string> GetListFromUser() {
        List<string> thisOne = new();
        return thisOne;
    }
}