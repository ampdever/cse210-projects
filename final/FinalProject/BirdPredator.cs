public class BirdPredator : Bird {
    //I need to come up with a better private attributes for the Mammals
    private string _huntTime;

    public BirdPredator(string name, string habitat, string food, string sound, string fly, string time) 
        : base (name, habitat, food, sound, fly) {
            //other attributes of mammals should be assigned here
            _huntTime = time;

    }

    public override void makeSound() {
        Console.WriteLine("birdPredator.makeSound");
    }

    public override void displayAnimal() {
        Console.WriteLine("birdPredator.displayAnimal()");
    }


}