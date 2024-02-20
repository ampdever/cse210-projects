public class Zoo {
    private List<Animal> _animals = new List<Animal>();

    public Zoo() {

    }

    public void Start() {
        Console.WriteLine("Welcome to the Zoo!");
        Console.WriteLine("Menu");
        Console.WriteLine("1. Add an animal");
        Console.WriteLine("2. View an animal");
        Console.WriteLine("3. Hear an animal");
        Console.WriteLine("4. List all animals");
        Console.WriteLine("5. Leave the Zoo");
        Console.Write("What would you like to do: ");
        int input = int.Parse(Console.ReadLine());

        while (input != 5) {
            if(input == 1) {
                AddAnimal();
            } else if (input == 2) {
                ShowAnimal();
            } else if (input == 3) {
                ShowAllAniamls();
            } else if (input == 4) {
                ShowAllAniamls();
            } else if (input == 8) {
                Mammal mammalOne = new("Mouse", "fields", "cheese", "squeak");
                Mammal mammalTwo = new("Zebra", "praries", "grass", "yip");
                _animals.Add(mammalOne);
                _animals.Add(mammalTwo);
                Reptile repOne = new("Turtle", "water areas", "cabbage", "small");
                Reptile repTwo = new("Gila monster", "desert", "bugs", "medium");
                _animals.Add(repOne);
                _animals.Add(repTwo);
                BirdPredator pBird = new("Hawk", "open fields", "small mammals", "screeech!!!", "y", "daytime");
                BirdForager fBirdOne = new("Cardinal", "brush", "berries", "chirp", "y", "bushes");
                BirdForager fBirdTwo = new("Ostrich", "Africa", "foliage", "squawk", "n", "floor");
                _animals.Add(pBird);
                _animals.Add(fBirdOne);
                _animals.Add(fBirdTwo);
            } else Console.WriteLine("Please make a valid choice.");

            Thread.Sleep(2000);

            Console.WriteLine("\n");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add an animal");
            Console.WriteLine("2. View an animal");
            Console.WriteLine("3. Hear an animal");
            Console.WriteLine("4. List all animals");
            Console.WriteLine("5. Leave the Zoo");
            Console.Write("What would you like to do: ");
            input = int.Parse(Console.ReadLine());
        }
    }

    public void AddAnimal() {
        Console.WriteLine("What type of animal would you like to add?");
        Console.WriteLine("1. Mammal");
        Console.WriteLine("2. Reptile");
        Console.WriteLine("3. Bird");
        int input = int.Parse(Console.ReadLine());

        if(input == 1) {
            Console.Write("What is the name of the mammal: ");
            string name = Console.ReadLine();
            Console.Write($"What habitat does the {name} live in: ");
            string habitat = Console.ReadLine();
            Console.Write($"What food does the {name} eat: ");
            string food = Console.ReadLine();
            Console.Write($"What sound does the {name} make: ");
            string sound = Console.ReadLine();

            Mammal newMammal = new(name, habitat, food, sound);
            _animals.Add(newMammal);

        } else if (input == 2) {
            Console.Write("What is the name of the reptile: ");
            string name = Console.ReadLine();
            Console.Write($"What habitat does the {name} live in: ");
            string habitat = Console.ReadLine();
            Console.Write($"What food does the {name} eat: ");
            string food = Console.ReadLine();
            Console.Write($"How big is the {name}: ");
            string size = Console.ReadLine();

            Reptile newReptile = new(name, habitat, food, size);
            _animals.Add(newReptile);

        } else if (input == 3) {
            Console.WriteLine("What type of bird is it?");
            Console.WriteLine("1. Predator bird");
            Console.WriteLine("2. Foraging bird");
            Console.Write("Enter the type of bird: ");
            int birdType = int.Parse(Console.ReadLine());

            if (birdType == 1) {
                Console.Write("What is the name of the bird: ");
                string name = Console.ReadLine();
                Console.Write($"What habitat does the {name} live in: ");
                string habitat = Console.ReadLine();
                Console.Write($"What food does the {name} eat: ");
                string food = Console.ReadLine();
                Console.Write($"What sound does the {name} make: ");
                string sound = Console.ReadLine();
                Console.Write($"Does the {name} fly(y/n): ");
                string fly = Console.ReadLine();
                Console.Write($"When does the {name} hunt: ");
                string time = Console.ReadLine();

                BirdPredator newBird = new(name, habitat, food, sound, fly, time);
                _animals.Add(newBird);
            } else if (birdType == 2) {
                Console.Write("What is the name of the bird: ");
                string name = Console.ReadLine();
                Console.Write($"What habitat does the {name} live in: ");
                string habitat = Console.ReadLine();
                Console.Write($"What food does the {name} eat: ");
                string food = Console.ReadLine();
                Console.Write($"What sound does the {name} make: ");
                string sound = Console.ReadLine();
                Console.Write($"Does the {name} fly(y/n): ");
                string fly = Console.ReadLine();
                Console.Write($"When does the {name} find its food: ");
                string location = Console.ReadLine();

                BirdForager newBird = new(name, habitat, food, sound, fly, location);
                _animals.Add(newBird);
            } else Console.WriteLine("Sorry, that was an invalid choice");
        }

    }

    public void ShowAnimal() {

        Console.WriteLine("Here are all the animals in the Zoo");

        int count = 1;
        foreach(Animal animal in _animals){
            Console.WriteLine($"{count}. {animal.getName()}");
            count++;
        }

        Console.WriteLine("Which animal would you like to look at?");
        int answer = int.Parse(Console.ReadLine());

        _animals[answer-1].displayAnimal();
    }

    public void ShowAllAniamls() {
        int count = 1;
        foreach(Animal animal in _animals){
            Console.WriteLine($"\n{count}. {animal.getName()}");
            Console.WriteLine($"\tHabitat: {animal.getHabitat()}");
            Console.WriteLine($"\tFood: {animal.getFoodType()}");
            Console.WriteLine($"\tSound: {animal.makeSound()}");
            count++;
        }
    }

    public void HearAnimal() {
        Console.WriteLine("Here are all the animals in the Zoo");

        int count = 1;
        foreach(Animal animal in _animals){
            Console.WriteLine($"{count}. {animal.getName()}");
            count++;
        }

        Console.WriteLine("Which animal would you like to hear?");
        int answer = int.Parse(Console.ReadLine());

        _animals[answer-1].makeSound();
    }
}