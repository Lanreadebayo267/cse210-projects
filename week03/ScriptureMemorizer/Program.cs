using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program!");
        Console.Write("Choose difficulty (1=Easy, 3=Medium, 5=Hard): ");
        int hideCount = int.Parse(Console.ReadLine());

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("1 Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be and men are that they might have joy.")
        };

        Random rand = new Random();
        Scripture selectedScripture = scriptures[rand.Next(scriptures.Count)];

        while (!selectedScripture.AllWordsHidden())
        {
            Console.Clear();
            selectedScripture.Display();
            selectedScripture.ShowProgressBar();

            Console.WriteLine("\nPress ENTER to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
                break;

            selectedScripture.HideWords(hideCount);
        }

        Console.Clear();
        selectedScripture.Display();
        Console.WriteLine("\nAll words hidden. Well done!");
    }
}

// EXCEEDS REQUIREMENTS:
// - Loads from a list of multiple scriptures randomly.
// - Only hides visible words (prevents re-hiding).
// - Displays memorization progress bar and percentage.
// - Allows user to choose difficulty (number of words hidden per round).
