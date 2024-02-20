public class BirdPredator : Bird {

    private string _huntTime;

    public BirdPredator(string name, string habitat, string food, string sound, string fly, string time) 
        : base (name, habitat, food, sound, fly) {

            _huntTime = time;

    }

    public override string makeSound() {
        return getSound();
    }

    public override void displayAnimal() {
        Console.WriteLine($"The {getName()} lives in a {getHabitat()} and eats {getFoodType()}\n\tThe hunt during the {_huntTime} time.");
    }


}