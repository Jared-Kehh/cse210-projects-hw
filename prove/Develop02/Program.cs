using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Entry!");
        Display _display = new Display();
        _display.AddEntry(new Prompt("What do you want to do today?"));
        _display.AddEntry(new Prompt("How can you be more nice to others?"));
        _display.AddEntry(new Prompt("What have you done today?"));
        _display.AddEntry(new Prompt("What is your favorite candy?"));
        _display.AddEntry(new Prompt("What is your dream day?"));
        Menu _menu = new Menu(_display);

        _menu.DisplayMenu();
    }
}