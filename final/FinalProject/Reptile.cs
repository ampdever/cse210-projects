public class Reptile : Animal {
    //I need to come up with a better private attributes for the reptiles
    private string _size;

    public Reptile(string name, string habitat, string food, string size) 
        : base (name, habitat, food) {
            //other attributes of mammals should be assigned here
            _size = size;
    }

    public override void makeSound() {
        Console.WriteLine("reptile.makeSound");
    }

    public override void displayAnimal() {
        Console.WriteLine("reptile.displayAnimal()");
    }


}