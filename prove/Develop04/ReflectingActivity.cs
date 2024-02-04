public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string desc, int dur, List<string> prompts, List<string> questions) 
        : base(name, desc, dur) {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run() {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"\t--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (DateTime.Now < futureTime) {
            Console.Write("You may begin in...");
            for (int i = 5; i >= 1; i--) {
                Console.Write($"\rYou may begin in...{i}");
                Thread.Sleep(1000);
            }
            Console.Clear();
        }
        
        DateTime startTimeTwo = DateTime.Now;
        DateTime futureTimeTwo = startTime.AddSeconds(getDuration());
        while(DateTime.Now < futureTimeTwo) {
            Console.Write($"{GetRandomQuestion()} ");
            ShowSpinner(5);
        }
    }

    public string GetRandomPrompt() {
        Random rand = new();
        int num = rand.Next(0, _prompts.Count());
        return $"{_prompts[num]}";
    }

    public string GetRandomQuestion() {
        Random rand = new();
        int num = rand.Next(0, _questions.Count());
        return $"> {_questions[num]}";
    }

    public void DisplayPrompt() {
        // display whatever
    }

    public void DisplayQuestions() {
        // put out the questions
    }
}