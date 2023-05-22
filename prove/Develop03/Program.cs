using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", "3", "5", "6");
        scripture scripture = new scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture()); 
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or 'quit' to finish:");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Make sure you memorized the scripture before starting!");
    }
}