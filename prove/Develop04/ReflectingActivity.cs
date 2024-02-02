public class ReflectingActivity : Activity {
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string desc, int dur) 
        : base(name, desc, dur) {
        //stuff now
    }

    public void Run() {
        // run the block
    }

    public string GetRandomPrompt() {
        return "";
    }

    public string GetRandomQuite() {
        return "";
    }

    public void DisplayPrompt() {
        // display whatever
    }

    public void DisplayQuestions() {
        // put out the questions
    }
}