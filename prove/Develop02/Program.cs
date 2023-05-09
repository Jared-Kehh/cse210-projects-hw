using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Entry!");
        Display _display = new Display();
        _display.AddEntry(new Prompt("Today I had hash browns!"));
        _display.AddEntry(new Prompt("Yesterday was sunday and I went to church."));

        Menu _menu = new Menu(_display);

        _menu.DisplayMenu();
        
    }
}