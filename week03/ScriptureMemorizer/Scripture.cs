using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
        _random = new Random();
    }

    public void Display()
    {
        Console.WriteLine($"\n{_reference}");
        Console.WriteLine();
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    public void HideWords(int count)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    public void ShowProgressBar()
    {
        int hidden = _words.Count(w => w.IsHidden());
        int total = _words.Count;
        int percent = (int)((hidden / (double)total) * 100);
        int bars = percent / 10;

        Console.WriteLine($"\nMemorized: {hidden}/{total} words hidden");
        Console.WriteLine("[" + new string('█', bars) + new string('-', 10 - bars) + $"] {percent}%");
    }
}