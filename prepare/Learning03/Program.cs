using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");

        Fraction firstCon = new();
        Fraction secondCon = new(6);
        Fraction thirdCon = new(6,7);

        // firstCon.SetTop(5);
        // firstCon.SetBottom(6);
        // Console.WriteLine($"{firstCon.GetTop()}/{firstCon.GetBottom()}");

        Fraction exOne = new();
        Fraction exTwo = new(5);
        Fraction exThree = new(3,4);
        Fraction exFour = new(1,3);

        Console.WriteLine(exOne.GetFractionString());
        Console.WriteLine(exOne.GetDecimalValue());
        Console.WriteLine(exTwo.GetFractionString());
        Console.WriteLine(exTwo.GetDecimalValue());
        Console.WriteLine(exThree.GetFractionString());
        Console.WriteLine(exThree.GetDecimalValue());
        Console.WriteLine(exFour.GetFractionString());
        Console.WriteLine(exFour.GetDecimalValue());
    }
}