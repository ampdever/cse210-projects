public class Prompts {
    Random rand  = new();
    List<string> promptList = new() {
        "What was your favorite thing you did?",
        "What happened today?",
        "What was the worst thing that happened?",
        "What is something you were grateful for?",
        "What did you learn?",
        "What surprised you?",
        "What did you do that you are proud of?",
        "What was something that was challenging for you?",
        "What is something interesting you learned?",
        "What would you change about today?"
    };

    public string getPrompt() {
        int num = rand.Next(0,10);
        return promptList[num];
    }
}