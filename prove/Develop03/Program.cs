using System;

class Program
{
    static void Main(string[] args)
    {
        string firstScripture = "And he shall go forth, suffering pains and afflictions and\ntemptations of every kind; and this that the word might be\nfulfilled which saith he will take upon him the pains and\nthe sicknesses of his people.";
        Word _word = new Word(firstScripture);
        ScripReference _reference = new ScripReference();
        _reference.DisplayVerse("Alma", 11, 7);
        _word.Display();


    }
}