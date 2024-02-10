using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.IO;
using System.Globalization;

public class GoalManager {
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager() {
        //double check this....idk what the constructor holds
    }

    public void Start() {

        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Event");
        Console.WriteLine("\t6. Quit");
        Console.Write("Select a choice from the menu: ");
        int input = int.Parse(Console.ReadLine());
        while (input != 6) {
            if(input == 1) {
                CreateGoal();
                Console.WriteLine("You have created a new goal!");
                Thread.Sleep(3000);
            } else if (input == 2) {
                ListGoalDetails();
                Thread.Sleep(3000);
            } else if (input == 3) {
                SaveGoals();
                Thread.Sleep(3000);
            } else if (input == 4) {
                LoadGoals();
                Thread.Sleep(3000);
            } else if (input == 5) {
                RecordEvent();
                Thread.Sleep(3000);
            } else Console.WriteLine("Please make a valid selection");

            Console.WriteLine();
            Console.WriteLine($"You have {_score} points.");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = int.Parse(Console.ReadLine());
        }
    }

    public void DisplayPlayerInfo() {
        Console.WriteLine(_score);
    }

    public void ListGoalNames() {
        // lists the names of each of the goals
    }

    public void ListGoalDetails() {
        //lists the details of each goal (including the checkbox)
        int count = 1;
        string comp;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals) {
            if (goal.isComplete()){
                comp = "X";
            } else comp = " ";
            Console.WriteLine($"{count}. [{comp}] {goal.GetDetailsString()}");
            count++;
        }
    }

    public void CreateGoal() {
        //asks user for the information about a new goal then
        //creates the goal and adds it to the list
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal do you want to make: ");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1) { // create simple goal

            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal: ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            string point = Console.ReadLine();

            SimpleGoal sGoal = new(name, desc, point);
            _goals.Add(sGoal);

        } else if (goalType == 2) { //create eternal goal
            
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal: ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            string point = Console.ReadLine();

            EternalGoal eGoal = new(name, desc, point);
            _goals.Add(eGoal);

        } else if (goalType == 3) { //create chekclist goal
            
            Console.Write("What is the name of your goal: ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of your goal: ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal: ");
            string point = Console.ReadLine();
            Console.Write("How many times does this goal need to be accomplished for a bonus: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal cGoal = new(name, desc, point, target, bonus);
            _goals.Add(cGoal);

        } else Console.WriteLine("That is an invalid selection\n");
    }

    public void RecordEvent() {

        Console.WriteLine("Which goal did you accomplish: ");
        int addedPoints = 0;
        int count = 0;
        foreach (Goal goal in _goals) {
            Console.WriteLine($"{count+1}. {goal.GetName()}");
            count++;
        }
        int accGoal = int.Parse(Console.ReadLine()) - 1;

        _goals[accGoal].RecordEvent();
        addedPoints = int.Parse(_goals[accGoal].GetPoints());

        // if its a checklist goal we're going to check for bonus points
        // else just add points to the other types of goals.
        if (_goals[accGoal] is ChecklistGoal checklistGoal) { 

            //if they have finished the checklist goal then they get bonus points
            //else they will just get normal points for recording the goal
            if(_goals[accGoal].isComplete()){
                Console.WriteLine($"Congradulations! You have earned {addedPoints + _goals[accGoal].GetBonus()}");
                _score += addedPoints + _goals[accGoal].GetBonus();
            } else {
                Console.WriteLine($"Congradulations! You have earned {addedPoints}!");
                _score += addedPoints;
            }

        } else { 
            Console.WriteLine($"Congradulations! You have earned {addedPoints}!");
            _score += addedPoints;
        }
    }

    public void SaveGoals() {
        Console.Write("Enter a name for a file to save to (e.g. goals.txt): ");
        string fileName = Console.ReadLine();

        using (StreamWriter writeOut = new StreamWriter(fileName)) {
            writeOut.WriteLine(_score);
            foreach (Goal goal in _goals) {
                writeOut.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        Console.Write("What is the name of the file you want o load: ");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        if (int.TryParse(lines[0], out int score)) {
            _score = score;

            foreach (string line in lines.Skip(1)) {
                string[] parts = line.Split("=");
                if (parts[0] == "SG") {
                    SimpleGoal newSG = new(parts[1], parts[2], parts[3]);
                    newSG.setComplete(parts[4]);
                    _goals.Add(newSG);
                } else if (parts[0] == "EG") {
                    EternalGoal newEG = new(parts[1], parts[2], parts[3]);
                    _goals.Add(newEG);
                } else if (parts[0] == "CG") {
                    ChecklistGoal newCG = new(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]));
                    newCG.setAmountCompleted(parts[6]);
                    _goals.Add(newCG);
                }
            }
        } else Console.WriteLine("Something went wrong");
    }
}