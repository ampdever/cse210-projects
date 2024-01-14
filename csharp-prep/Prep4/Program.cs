using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int input = -1;

        while (input != 0) {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }

        int sum = 0;
        int count = 0;
        int largest = 0;
        foreach (int num in numbers) {
            sum += num;
            count++;
            if (num > largest) largest = num;
        }
        int average = sum/count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}