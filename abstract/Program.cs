// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn", "Brandon Sanderson");
Book HungerGames = new Book("Hunger Games", "Suzanne Collins");

mistborn.Display();
HungerGames.Display();

Console.WriteLine(mistborn.IsAvailable());
