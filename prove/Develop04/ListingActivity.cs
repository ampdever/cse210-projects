public class ListingActivity : Activity {
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string desc, int dur) 
        : base (name, desc, dur) {
        //Listing constructor add whatever I need here
    }

    public void Run() {
        //run this boi
    }

    public void GetRandomPrompt() {
        // this is where the prompt comes from
    }

    public List<string> GetListFromUser() {
        List<string> thisOne = new();
        return thisOne;
    }
}