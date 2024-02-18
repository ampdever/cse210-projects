public class Bird : Animal {
    //I need to come up with a better private attributes for the Mammals
    private string _sound;
    private bool _canFly;

    public Bird(string name, string habitat, string food, string sound, string fly) 
        : base (name, habitat, food) {
            //other attributes of mammals should be assigned here
            _sound = sound;
            _canFly = bool.Parse(fly);
    }

    public virtual void makeSound() {
        Console.WriteLine("bird.makeSound");
    }

    public virtual void displayAnimal() {
        Console.WriteLine("bird.displayAnimal()");
    }


}