public class Activity {
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string desc, int dur) {
        _name = name;
        _description = desc;
        _duration = dur;
    }

    public void DisplayStartingMessage() {
        //display starting message
    }

    public void DisplayEndingMessage() {
        //display ending message
    }

    public void ShowSpinner(int seconds) {
        //display the spinner animation
        //using / | \ | 
    }

    public void ShowCountDown(int seconds) {
        //display countdown to the console
    }
}