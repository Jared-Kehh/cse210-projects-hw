using System;

class Program
{
    static void Main(string[] args)
    {
        Word _word = new Word();
        ScripReference _reference = new ScripReference();
        _reference.DisplayVerse("Alma", 11, 7);
        _word.Display();
        _word.HideWord();

    }
}