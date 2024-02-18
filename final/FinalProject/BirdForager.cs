public class BirdForager : Bird {
    //I need to come up with a better private attributes for the Mammals
    private string _foodLocation;

    public BirdForager(string name, string habitat, string food, string sound, string fly, string location) 
        : base (name, habitat, food, sound, fly) {
            //other attributes of mammals should be assigned here
            _foodLocation = location;

    }

    public override void makeSound() {
        Console.WriteLine("BirdForager.makeSound");
    }

    public override void displayAnimal() {
        Console.WriteLine("BirdForager.displayAnimal()");
    }


}