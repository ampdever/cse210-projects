using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        Console.WriteLine("Please select one of the folloing choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        string input = Console.ReadLine();
        File fil = new();
        Prompts pro =  new();
            
        string prompt;
        string entry;
    
        while(input != "5") {
            Entry ent = new();

            if (input == "1") {
                //prompting user and getting response
                prompt = pro.getPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                entry = Console.ReadLine();
                
                //assigning the values to the entry class
                ent._promptText = prompt;
                ent._entryText = entry;
                DateTime currentTime = DateTime.Now;
                ent._date = currentTime.ToShortDateString();
                
                //adding the entry to the list of entries in file class
                fil.AddEntry(ent);
                
            } else if (input == "2") {

                fil.DisplayAll();

            } else if (input == "3") {
                
                // Console.Write("Enter file you want to load: ");
                // string fileName = Console.ReadLine();
                // fil.LoadFromFile(fileName);
                Console.WriteLine("This is where people would load a file");

            } else if (input == "4") {
                
                //entering name for user file
                Console.Write("Enter a name for your file: ");
                string fileName = Console.ReadLine();
                fil.SaveToFile(fileName);

            } else if (input == "5") {
                break;
            } else {
                Console.WriteLine("please enter a valid response 1-5");
            }
            Console.WriteLine("\nPlease select one of the folloing choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

        }
    }
}