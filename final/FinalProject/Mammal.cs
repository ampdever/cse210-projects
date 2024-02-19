public class Mammal : Animal {
    //I need to come up with a better private attributes for the Mammals
    private string _sound;

    public Mammal(string name, string habitat, string food, string sound) 
        : base (name, habitat, food) {
            _sound = sound;
    }

    public override void makeSound() {
        Console.WriteLine("Mammal.makeSound");
    }

    public override void displayAnimal() {
        Console.WriteLine("mammal.displayAnimal()");
    }


}