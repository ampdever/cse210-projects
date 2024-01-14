using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Random rand = new();
        int magicNumber = rand.Next(1,101);

        int quitter = 0;
        int guesses = 0;

        while (quitter != magicNumber) {
            Console.Write("What is your guess? ");
            quitter = int.Parse(Console.ReadLine());
            guesses++;

            if (quitter > magicNumber) {
                Console.WriteLine("Lower");
            } else if (quitter < magicNumber) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine($"Correct! You guessed it in {guesses} tries!");
                Console.Write("Would you like to play again? (y/n) ");
                string response = Console.ReadLine();
                if (response == "y") {
                    guesses = 0;
                    quitter = 0;
                    magicNumber = rand.Next(1,101);
                } else Console.WriteLine("Thanks for playing!");
            }
        }
    }
}