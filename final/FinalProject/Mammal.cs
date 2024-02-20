public class Mammal : Animal {

    private string _sound;

    public Mammal(string name, string habitat, string food, string sound) 
        : base (name, habitat, food) {
            _sound = sound;
    }

    public override string makeSound() {
        return _sound;
    }

    public override void displayAnimal() {
        Console.WriteLine($"The {getName()} lives in a {getHabitat()} and eats {getFoodType()}\n\tThe {getName()} goes {_sound}");
    }


}