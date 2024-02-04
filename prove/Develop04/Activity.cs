public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(){}

    public Activity(string name, string desc, int dur) {
        _name = name;
        _description = desc;
        _duration = dur;
    }

    public void DisplayStartingMessage() {
        Console.Clear();
        Console.WriteLine("Get Ready...");
    }

    public void DisplayEndingMessage() {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"You've completed {_duration} seconds of {_name} Activity!");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime) {
            Console.Write("|");
            Thread.Sleep(175);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(175);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(175);
            Console.Write("\b \b");

            Console.Write("/");
            Thread.Sleep(175);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(175);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(175);
            Console.Write("\b \b");
        }
        Console.WriteLine("\n");
    }

    public void ShowCountDown(int seconds) {
        //display countdown to the console
    }

    public int getDuration() {
        return _duration;
    }
}