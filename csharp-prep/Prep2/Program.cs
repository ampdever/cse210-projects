using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();

        int gradeInt = int.Parse(gradeString);

        // if (gradeInt >= 90) {
        //     Console.WriteLine("Your grade is A");
        // } else if (gradeInt >= 80) {
        //     Console.WriteLine("Your grade is B");
        // } else if (gradeInt >= 70) {
        //     Console.WriteLine("Your grade is C");
        // } else if (gradeInt >= 60) {
        //     Console.WriteLine("Your grade is D");
        // } else {
        //     Console.WriteLine("Your grade is F");
        // }
        string letter;
        if (gradeInt >= 90) {
            letter = "A";
        } else if (gradeInt >= 80) {
            letter = "B";
        } else if (gradeInt >= 70) {
            letter = "C";
        } else if (gradeInt >= 60) {
            letter = "D";
        } else letter = "F";

        int extra = gradeInt % 10;
        string modder;

        if (extra >= 7) {
            modder = "+";
        } else if (extra < 3) {
            modder = "-";
        } else modder = "";

        if (letter == "A" && modder == "+" || gradeInt == 100) {
            Console.WriteLine($"Your grade is {letter}");
        } else if (letter == "F") {
            Console.WriteLine($"Your grade is {letter}");
        } else Console.WriteLine($"Your grade is {letter}{modder}");
        

        if (gradeInt >= 70) {
            Console.WriteLine("Congradulations! You passed the course!");
        } else Console.WriteLine("Better luck next time.");


    }
}