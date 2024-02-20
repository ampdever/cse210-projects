public class Bird : Animal {

    private string _sound;
    private bool _canFly;

    public Bird(string name, string habitat, string food, string sound, string fly) 
        : base (name, habitat, food) {

            _sound = sound;
            if (fly == "Y" || fly == "y") {
                _canFly = true;
            } else _canFly = false;
            
    }

    public override string makeSound() {
        return _sound;
    }

    public override void displayAnimal() {
        Console.WriteLine($"The {getName()} lives in a {getHabitat()} and eats {getFoodType()}\n\tThe {getName()} goes {_sound}");
    }

    public string getSound() {
        return _sound;
    }

    public string canFly() {
        return _canFly.ToString();
    }


}