public class BreathingActivity : Activity {
    
    public BreathingActivity(string name, string desc, int dur) 
        : base(name, desc, dur) {
        //this is the constructor
    }

    public void Run(int duration){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        while (DateTime.Now < futureTime) {
            Console.Write("Breathe in...");
            for (int i = 4; i >= 1; i--) {
                Console.Write($"\rBreathe in...{i}");
                Thread.Sleep(1000);
            }
            Console.Write("\b \b");
            Console.Write("\nBreathe out...");
            for (int i = 6; i >= 1; i--) {
                Console.Write($"\rBreathe out...{i}");
                Thread.Sleep(1000);
            }
            
            Console.WriteLine("\n");
        }

    }
}