using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Console.Clear();


        Assignment first = new("Samuel Bennett", "Multiplication");
        Console.WriteLine(first.GetSummary());

        MathAssignment math = new("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        WritingAssignment write = new("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(write.GetSummary());
        Console.WriteLine(write.GetWritingInformation());
    }
}