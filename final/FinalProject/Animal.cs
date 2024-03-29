public class Animal {
    private string _name;
    private string _habitat;
    private string _foodType;

    public Animal (string name, string habitat, string food) {
        _name = name;
        _habitat = habitat;
        _foodType = food;
    }

    public virtual string makeSound() {
        return "";
    }

    public virtual void displayAnimal() {
        //this is the function that grabs all the private info and displays it. 
        Console.WriteLine("Animal.displayAnimal()");
    }

    public string getName() {
        return _name;
    }

    public string getHabitat() {
        return _habitat;
    }

    public string getFoodType() {
        return _foodType;
    }
}