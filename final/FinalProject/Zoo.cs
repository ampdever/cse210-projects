public class Zoo {
    private List<Animal> _animals;

    public Zoo() {
        //basically a default constructor for the Zoo class
    }

    public void Start() {
        Console.WriteLine("in the start function for Zoo");
    }

    public void AddAnimal() {
        //give the user the option to add animals
        Console.WriteLine("inside Zoo.AddAnimal()");
    }

    public void ShowAnimal() {
        //give the user the option to look at the animals and choose which
        //one they want to see
        Console.WriteLine("Zoo.ShowAnimal()");
    }

    public void ShowAllAniamls() {
        //this is going to have a foreach loop to view all the animals, their names and stuff
    }
}