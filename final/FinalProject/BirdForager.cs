public class BirdForager : Bird {

    private string _foodLocation;

    public BirdForager(string name, string habitat, string food, string sound, string fly, string location) 
        : base (name, habitat, food, sound, fly) {

            _foodLocation = location;

    }

    public override string makeSound() {
        return getSound();
    }

    public override void displayAnimal() {
        Console.WriteLine($"The {getName()} lives in a {getHabitat()} and eats {getFoodType()}\n\tThey gather food around {_foodLocation} areas.");
    }


}