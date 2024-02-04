using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        string bName = "Breathing";
        string bDesc = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long, in seconds, would you like for your session? ";
        string rName = "Reflecting";
        string rDesc = "Welcome to the Reflecting Activity.\n\nThis activity will help you reflect on times in oyour life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nHow long, in seconds, would you like for your session? ";
        string lName = "Listing";
        string lDesc = "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long, in seconds, would you like for your session? ";

        List<string> prompts = new();
        prompts.Add("Think of a time when you did something really difficult.");
        List<string> questions = new();
        questions.Add("How did you feel when it was complete?");
        questions.Add("What is your favorite thing about this experience?");



////////////////// THIS IS WHERE THE PROGRAM STARTS ////////////////////////////////////////////
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("\t1. Start breathing activity");
        Console.WriteLine("\t2. Start reflecting activity");
        Console.WriteLine("\t3. Start listing activity");
        Console.WriteLine("\t4. Quit");
        Console.Write("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        while(choice != 4) {

            if (choice == 1) {
                Console.Clear();
                Console.Write(bDesc);
                int seconds = int.Parse(Console.ReadLine());
                BreathingActivity bActivity = new(bName, bDesc, seconds);
                int howLong = bActivity.getDuration();

                bActivity.DisplayStartingMessage();
                bActivity.ShowSpinner(5);

                bActivity.Run(howLong);

                bActivity.DisplayEndingMessage();
            } else if (choice == 2) {
                Console.Clear();
                Console.Write(rDesc);
                int seconds = int.Parse(Console.ReadLine());
                ReflectingActivity rActivity = new(rName, rDesc, seconds, prompts, questions);
                int howLong = rActivity.getDuration();

                rActivity.DisplayStartingMessage();
                rActivity.ShowSpinner(5);
                
                rActivity.Run();

                rActivity.DisplayEndingMessage();
            } else if (choice == 3) {
                Console.Clear();
                Console.Write(lDesc);
                int seconds = int.Parse(Console.ReadLine());
                ListingActivity lActivity = new(lName, lDesc, seconds, prompts);
                int howLong = lActivity.getDuration();

                lActivity.DisplayStartingMessage();
                lActivity.ShowSpinner(5);

                lActivity.Run();
            } else Console.WriteLine("Please make a valid selection.");

            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

        }
    }
}