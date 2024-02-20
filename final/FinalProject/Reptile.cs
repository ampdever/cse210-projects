public class Reptile : Animal {

    private string _size;

    public Reptile(string name, string habitat, string food, string size) 
        : base (name, habitat, food) {
            _size = size;
    }

    public override string makeSound() {
        return "Retiles don't really make sounds...";
    }

    public override void displayAnimal() {
        Console.WriteLine($"The {getName()} lives in a {getHabitat()} and eats {getFoodType()}\n\tThis particular reptile is {_size}");
    }


}