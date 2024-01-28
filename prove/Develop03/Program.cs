using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        
        //storing scriptures.
        /* 
           The first one, Nephi, is an example of a single verse scripture.
           The second one, Proverbs, is an example of a multi verse one.
        */
        Reference nephi = new("1 Nephi", 11, 17);
        Reference proverbs = new("Proverbs", 3, 5, 6);
        string nephiString = "And I said unto him I know that he loveth his children nevertheless I do not know the meaning of all things";
        string proverbsString = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";
        Scripture nephiScripture = new(nephi, nephiString);
        Scripture provScripture = new(proverbs, proverbsString);

        Console.Clear();
        //display full scripture
        Console.WriteLine(nephiScripture.GetDisplayText());


        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();
        while (input != "quit" || nephiScripture.IsCompletelyHidden()) {
            Console.Clear();
            nephiScripture.HideRandomWord(3);
            Console.WriteLine(nephiScripture.GetDisplayText());
            //display scripture - 3 random words

            Console.Write("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
        }
    }
}